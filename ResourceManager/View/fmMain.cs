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
        #region View

        /// <summary>
        /// Выбранная библиотека
        /// </summary>
        public string SelectedLibrary
        {
            get => this.slueLibrary.EditValue.ToString();
            set => this.slueLibrary.EditValue = value;
        }

        /// <summary>
        /// Выбранный ресурс
        /// </summary>
        public string SelectedResource
        {
            get => this.slueResource.EditValue.ToString();
            set => this.slueResource.EditValue = value;
        }

        /// <summary>
        /// Каталог
        /// </summary>
        public string SelectedPath
        {
            get => this.bePath.EditValue.ToString();
            set => this.bePath.EditValue = value;
        }

        /// <summary>
        /// Выбранный ресурс
        /// </summary>
        public SourceEnum SelectedSourceEnum
        {
            get => (SourceEnum)this.lueSource.EditValue;
            set => this.lueSource.EditValue = (int)value;
        }

        /// <summary>
        /// Списокэлементов ресурса
        /// </summary>
        public IList<ResourceItem> ResourceItemList
        {
            get => this.gcResourceItems.DataSource as List<ResourceItem>;
            set => this.gcResourceItems.DataSource = value;
        }

        /// <summary>
        /// Список библиотек
        /// </summary>
        public IList<string> LibraryList
        {
            get => this.slueLibrary.Properties.DataSource as List<string>;
            set => this.slueLibrary.Properties.DataSource = value;
        }

        /// <summary>
        /// Список ресурсов
        /// </summary>
        public IList<string> ResourceList
        {
            get => this.slueResource.Properties.DataSource as List<string>;
            set => this.slueResource.Properties.DataSource = value;
        }

        /// <summary>
        /// Словарь источников
        /// </summary>
        public Dictionary<int, string> SourceEnumDict
        {
            get => this.lueSource.Properties.DataSource as Dictionary<int, string>;
            set => this.lueSource.Properties.DataSource = value;
        }

        #endregion

        /// <summary>
        /// Экземпляр представления
        /// </summary>
        private readonly IMainPresenter _presenter;

        #region .ctor

        /// <summary>
        /// Конструктор
        /// </summary>
        public fmMain()
        {
            InitializeComponent();
            var resourceManager = new ResourceManager.Model.ResourceManager();
            this._presenter = new MainPresenter(this, resourceManager);
        }

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

        #region EditValueChanged

        private void fmMain_Load(object sender, EventArgs e)
        {
            this.TryCatch(() =>
            {
                this._presenter.Show();
            });
        }

        private void lueSource_EditValueChanged(object sender, EventArgs e)
        {
            this.TryCatch(() =>
            {
                this._presenter.SelectedSourceChange();
            });
        }

        private void bePath_EditValueChanged(object sender, EventArgs e)
        {
            this.TryCatch(() =>
            {
                this._presenter.SelectedPathChange();
            });
        }

        private void bePath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.TryCatch(() =>
            {
                var folderBrowserDialog = new FolderBrowserDialog();

                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                    return;

                this._presenter.SelectedPathChange(); ;
            });
        }

        private void slueLibrary_EditValueChanged(object sender, EventArgs e)
        {
            this.TryCatch(() =>
            {
                this._presenter.SelectedLibraryChange();
            });
        }

        private void slueResource_EditValueChanged(object sender, EventArgs e)
        {
            this.TryCatch(() =>
            {
                this._presenter.SelectedResourceChange();
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

                    this._presenter.CreateBackup();
                }

                this._presenter.SaveChanges();

                this.ShowInformationMessage(ProjectResource.SuccessSave);

            });
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.TryCatch(() =>
            {
                this._presenter.Close();
            });
        }

        #endregion
    }
}