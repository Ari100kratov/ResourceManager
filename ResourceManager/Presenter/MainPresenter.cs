using ResourceManager.Enums;
using ResourceManager.Model;
using ResourceManager.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManager.Presenter
{
    public class MainPresenter : IMainPresenter
    {
        private readonly IMainView _view;
        private readonly IResourceManager _resourceManager;

        public MainPresenter(IMainView view, IResourceManager resourceManager)
        {
            this._view = view;
            this._resourceManager = resourceManager;
        }


        public void SelectedLibraryChange()
        {
            this._view.ResourceList = this._view.SelectedLibrary != null
                    ? this._resourceManager.GetResourceList(this._view.SelectedLibrary).ToList()
                    : null;

            this._view.SelectedResource = null;
        }

        public void SelectedResourceChange()
        {
            this._view.ResourceItemList = this._resourceManager
                .GetResourceItemlist(this._view.SelectedResource).ToList();
        }

        public void SelectedPathChange()
        {
            this._resourceManager.ProjectPath = this._view.SelectedPath;
            this.RefreshLibraries();
        }

        public void SelectedSourceChange()
        {
            this._resourceManager.CurrentSourceEnum = this._view.SelectedSourceEnum;
            this.RefreshLibraries();
        }

        public void SaveChanges()
        {
            this._resourceManager.SaveChanges(this._view.SelectedResource, this._view.ResourceItemList);
        }

        public void CreateBackup()
        {
            this._resourceManager.CreateBackup(this._view.SelectedLibrary);
        }

        public void Show()
        {
            var sourceEnumDict = SourceEnumExtension.GetSourceEnumDict();
            this._view.SourceEnumDict = SourceEnumExtension.GetSourceEnumDict();
            this._view.SelectedSourceEnum = (SourceEnum)sourceEnumDict.FirstOrDefault().Key;

            this._view.SelectedPath = this._resourceManager.ProjectPath;
        }

        public void Close()
        {
            Settings.Default.Save();
        }

        /// <summary>
        /// Обновление списка библиотек
        /// </summary>
        private void RefreshLibraries()
        {
            this._view.LibraryList = Directory.Exists(this._resourceManager.LibraryFullPath)
                ? this._resourceManager.GetLibraryList().ToList()
                : null;

            this._view.SelectedLibrary = null;
        }
    }
}
