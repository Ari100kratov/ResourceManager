using ResourceManager.Enums;
using ResourceManager.Model;
using ResourceManager.View;
using System.IO;
using System.Linq;

namespace ResourceManager.Presenter
{
    /// <summary>
    ///  Представление основной формы
    /// </summary>
    public class MainPresenter : IMainPresenter
    {
        /// <summary>
        /// Экземпляр доступа к форме
        /// </summary>
        private readonly IMainView _view;

        /// <summary>
        ///  Экземпляр доступа к менеджеру ресурсов
        /// </summary>
        private readonly IResourceManager _resourceManager;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="view"></param>
        /// <param name="resourceManager"></param>
        public MainPresenter(IMainView view, IResourceManager resourceManager)
        {
            this._view = view;
            this._resourceManager = resourceManager;
        }

        /// <summary>
        ///  Событие изменения выбранной библиотеки ресурсов
        /// </summary>
        public void SelectedLibraryChange()
        {
            this._view.ResourceList = !string.IsNullOrWhiteSpace(this._view.SelectedLibrary)
                    ? this._resourceManager.GetResourceList(this._view.SelectedLibrary).ToList()
                    : null;

            this._view.SelectedResource = string.Empty;
        }

        /// <summary>
        ///  Событие изменения выбранного ресурса
        /// </summary>
        public void SelectedResourceChange()
        {
            this._view.ResourceItemList = !string.IsNullOrWhiteSpace(this._view.SelectedResource)
                ? this._resourceManager.GetResourceItemlist(this._view.SelectedResource).ToList()
                : null;
        }

        /// <summary>
        ///  Событие изменения выбранного каталога
        /// </summary>
        public void SelectedPathChange()
        {
            this._resourceManager.ProjectPath = this._view.SelectedPath;
            this.RefreshLibraries();
        }

        /// <summary>
        /// Событие изменения выбранного источника
        /// </summary>
        public void SelectedSourceChange()
        {
            this._resourceManager.CurrentSourceEnum = this._view.SelectedSourceEnum;
            this.RefreshLibraries();
        }

        /// <summary>
        ///  Сохранение изменений
        /// </summary>
        public void SaveChanges()
        {
            this._resourceManager.SaveChanges(this._view.SelectedResource, this._view.ResourceItemList);
        }

        /// <summary>
        ///  Создание резервной копии
        /// </summary>
        public void CreateBackup()
        {
            this._resourceManager.CreateBackup(this._view.SelectedLibrary);
        }

        /// <summary>
        /// Событие загрузки формы
        /// </summary>
        public void Show()
        {
            var sourceEnumDict = SourceEnumExtension.GetSourceEnumDict();
            this._view.SourceEnumDict = SourceEnumExtension.GetSourceEnumDict();
            this._view.SelectedSourceEnum = (SourceEnum)sourceEnumDict.FirstOrDefault().Key;

            this._view.SelectedPath = this._resourceManager.ProjectPath;
        }

        /// <summary>
        /// Событие закрытия формы
        /// </summary>
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

            this._view.SelectedLibrary = string.Empty;
        }
    }
}
