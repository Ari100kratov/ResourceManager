using System.Collections.Generic;

namespace ResourceManager
{
    /// <summary>
    /// Интерфейс взаимодействия менеджера ресурсов
    /// </summary>
    public interface IResourceManager
    {
        /// <summary>
        /// Возвращает список библиотек
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetLibraryList();

        /// <summary>
        /// Возвращает список ресурсов выбранной библиотеки
        /// </summary>
        /// <param name="libraryPath">Путь к месторасположению библиотеки</param>
        /// <returns></returns>
        IEnumerable<string> GetResourceList(string libraryPath);

        /// <summary>
        /// Возвращает список элементов выбранного ресурса
        /// </summary>
        /// <param name="resourceName">Наименование выбранного ресурса</param>
        /// <returns></returns>
        IEnumerable<ResourceItem> GetResourceItemlist(string resourceName);

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        /// <param name="resourceName">Выбранный ресурс</param>
        /// <param name="resourceItemList">Измененый список элементов ресурса</param>
        void SaveChanges(string resourceName, IEnumerable<ResourceItem> resourceItemList);

        /// <summary>
        /// Путь к проекту
        /// </summary>
        string ProjectPath { get; set; }

        /// <summary>
        /// Локализация
        /// </summary>
        string Language { get; set; }

        /// <summary>
        /// Путь к библиотеке ресурсов с учетом локализации
        /// </summary>
        string LibraryFullPath { get; }

        /// <summary>
        /// Резервное копирование данных
        /// </summary>
        /// <param name="libraryPath">Путь к библиотеке ресурсов включая наименование файла</param>
        void CreateBackup(string libraryPath);

        /// <summary>
        /// Текущий источник ресурсов
        /// </summary>
        SourceEnum CurrentSourceEnum { get; set; }
    }
}
