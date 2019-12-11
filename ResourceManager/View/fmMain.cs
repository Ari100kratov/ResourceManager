using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using ResourceManager.Enums;
using ResourceManager.Model;
using ResourceManager.View;
using ResourceManager.Presenter;

namespace ResourceManager
{
    public partial class fmMain : XtraForm, IMainView
    {
        public MainPresenter Presenter { set => throw new NotImplementedException(); }
        public string SelectedLibrary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SelectedResource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public SourceEnum SelectedSourceEnum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<ResourceItem> ResourceItemList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #region .ctor

        /// <summary>
        /// Конструктор
        /// </summary>
        public fmMain()
        {
            InitializeComponent();

            this.slueLibrary.EditValueChanged += this.SelectedLibraryChanged;
        }

        public event EventHandler SelectedLibraryChanged;
        public event EventHandler SelectedResourceChanged;
        public event EventHandler SelectedSourceEnumChanged;
        public event EventHandler SaveChanges;

        #endregion

        #region Helpers

        /// <summary>
        /// Обработка исключений
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        private T TryCatch<T>(Func<T> action)
        {
            try
            {
                var result = action.Invoke();

                return result;
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex.Message);
                return default(T);
            }
        }

        /// <summary>
        /// Обработка исключений
        /// </summary>
        /// <param name="action"></param>
        private void TryCatch(Action action)
        {
            try
            {
                action?.Invoke();
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex.Message);
            }
        }

        /// <summary>
        /// отобразить сообщение об ошибке
        /// </summary>
        private void ShowErrorMessage(string msgText)
        {
            XtraMessageBox.Show(msgText, ProjectResource.ErrorMessage_Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Отобразить предупреждающее сообщение
        /// </summary>
        private void ShowWarningMessage(string msgText)
        {
            XtraMessageBox.Show(msgText, ProjectResource.WarningMessage_Caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Отобразить информационное сообщение
        /// </summary>
        private void ShowInformationMessage(string msgText)
        {
            XtraMessageBox.Show(msgText, ProjectResource.InformationMessage_Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Отобразить сообщение требующее продтверждение
        /// </summary>
        /// <param name="msgText"></param>
        /// <returns></returns>
        private DialogResult ShowConfirmMessage(string msgText, string msgCaption)
        {
            return XtraMessageBox.Show(msgText, msgCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        #endregion

        #region Properties


        #endregion

        #region EditValueChanged

        private void fmMain_Load(object sender, EventArgs e)
        {
            this.TryCatch(() =>
            {
                var sourceEnumDict = SourceEnumExtension.GetSourceEnumDict();
                this.lueSource.Properties.DataSource = SourceEnumExtension.GetSourceEnumDict();
                this.lueSource.EditValue = sourceEnumDict.FirstOrDefault().Key;

                this.bePath.EditValue = this._resourceManager.ProjectPath;
            });
        }

        private void lueSource_EditValueChanged(object sender, EventArgs e)
        {
            this.TryCatch(() =>
            {
                this._resourceManager.CurrentSourceEnum = (SourceEnum)this.lueSource.EditValue;
                this.RefreshLibraries();
            });
        }

        private void bePath_EditValueChanged(object sender, EventArgs e)
        {
            this.TryCatch(() =>
            {
                this._resourceManager.ProjectPath = this.bePath.EditValue?.ToString();
                this.RefreshLibraries();
            });
        }

        /// <summary>
        /// Обновление списка библиотек
        /// </summary>
        private void RefreshLibraries()
        {
            this.slueLibrary.Properties.DataSource = Directory.Exists(this._resourceManager.LibraryFullPath)
                ? this._resourceManager.GetLibraryList()
                : null;

            this.slueLibrary.EditValue = null;
        }

        private void bePath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.TryCatch(() =>
            {
                var folderBrowserDialog = new FolderBrowserDialog();

                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                    return;

                this.bePath.EditValue = folderBrowserDialog.SelectedPath;
            });
        }

        private void slueLibrary_EditValueChanged(object sender, EventArgs e)
        {
            this.TryCatch(() =>
            {
                this.slueResource.Properties.DataSource = this.SelectedLibrary == null
                    ? null
                    : this._resourceManager.GetResourceList(this.SelectedLibrary);

                this.slueResource.EditValue = null;
            });
        }

        private void slueResource_EditValueChanged(object sender, EventArgs e)
        {
            this.TryCatch(() =>
            {
                this._resourceItemList = this._resourceManager.GetResourceItemlist(this.SelectedResource).ToList();
                this.gcResourceItems.DataSource = this._resourceItemList;
            });
        }

        #endregion

        #region Save

        private void sbSave_Click(object sender, EventArgs e)
        {
            this.TryCatch(() =>
            {
                if (string.IsNullOrWhiteSpace(this.SelectedResource))
                {
                    this.ShowWarningMessage(ProjectResource.ResourceNotSelected);
                    return;
                }

                var dialogResult = this.ShowConfirmMessage(ProjectResource.ConfirmCreateBackup, ProjectResource.CreateBackup_Dialog_Header);

                if (dialogResult == DialogResult.Cancel)
                    return;

                if (dialogResult == DialogResult.Yes)
                {
                    if (!File.Exists(this.SelectedLibrary))
                    {
                        this.ShowErrorMessage(ProjectResource.BackupError);
                        return;
                    }

                    this._resourceManager.CreateBackup(this.SelectedLibrary);
                }

                this._resourceManager.SaveChanges(this.SelectedResource, this._resourceItemList);

                this.ShowInformationMessage(ProjectResource.SuccessSave);

                this.RefreshAfterSave();
            });
        }

        /// <summary>
        /// Обновление данных после сохранения
        /// Требуется для освобождения ресурсов библиотеки, чтобы продолжить работать с утилитой
        /// </summary>
        private void RefreshAfterSave()
        {
            this._resourceManager = new ResourceManager();

            var rowHandle = this.gvResourceItems.FocusedRowHandle;
            var source = this.SelectedSourceEnum;
            var library = this.SelectedLibrary;
            var resource = this.SelectedResource;

            this.lueSource.EditValue = (int)source;

            this.slueLibrary.Properties.DataSource = this._resourceManager.GetLibraryList();
            this.slueLibrary.EditValue = library;

            this.slueResource.Properties.DataSource = this._resourceManager.GetResourceList(library);
            this.slueResource.EditValue = resource;

            this._resourceItemList = this._resourceManager.GetResourceItemlist(resource).ToList();
            this.gcResourceItems.DataSource = this._resourceItemList;
            this.gvResourceItems.FocusedRowHandle = rowHandle;
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.TryCatch(() =>
            {
                //Сохраняем настройки
                Settings.Default.Save();
            });
        }

        #endregion
    }
}