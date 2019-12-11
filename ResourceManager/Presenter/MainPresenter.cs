using ResourceManager.Enums;
using ResourceManager.Model;
using ResourceManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManager.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IResourceManager _resourceManager;

        public MainPresenter(IMainView view, IResourceManager resourceManager)
        {
            this._view = view;
            view.Presenter = this;
            this._resourceManager = resourceManager;

            this._view.SelectedLibraryChanged += _view_SelectedLibraryChanged;
            this._view.SelectedResourceChanged += _view_SelectedResourceChanged;
            this._view.SelectedSourceEnumChanged += _view_SelectedSourceEnumChanged;
            this._view.SaveChanges += _view_SaveChanges;
        }

        private void _view_SaveChanges(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_SelectedSourceEnumChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_SelectedResourceChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_SelectedLibraryChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Список библиотек ресурсов
        /// </summary>
        public List<string> LibraryList = new List<string>();

        /// <summary>
        /// Список ресурсов выбранной библиотеки
        /// </summary>
        public List<string> ResourceList = new List<string>();

        /// <summary>
        /// Список элементов выбранного ресурса
        /// </summary>
        public List<ResourceItem> ResourceItemList = new List<ResourceItem>();


        public string SelectedLibrary;

        public string SelectedResource;

        public SourceEnum SelectedSourceEnum;

    }
}
