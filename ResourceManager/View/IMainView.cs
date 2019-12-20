using ResourceManager.Enums;
using ResourceManager.Model;
using System.Collections.Generic;

namespace ResourceManager.View
{
    /// <summary>
    ///  Интерфейс вида
    /// </summary>
    public interface IMainView
    {
        /// <summary>
        /// Выбранная локализация
        /// </summary>
        LanguageEnum SelectedLanguageEnum { get; set; }

        /// <summary>
        /// Выбранная библиотека
        /// </summary>
        string SelectedLibrary { get; set; }

        /// <summary>
        /// Выбранный ресурс
        /// </summary>
        string SelectedResource { get; set; }

        /// <summary>
        /// Каталог
        /// </summary>
        string SelectedPath { get; set; }

        /// <summary>
        /// Выбранный источник
        /// </summary>
        SourceEnum SelectedSourceEnum { get; set; }

        /// <summary>
        /// Список элементов ресурса
        /// </summary>
        IList<ResourceItem> ResourceItemList { get; set; }

        /// <summary>
        /// Список библиотек
        /// </summary>
        IList<string> LibraryList { get; set; }

        /// <summary>
        /// Список ресурсов
        /// </summary>
        IList<string> ResourceList { get; set; }

        /// <summary>
        /// Словарь источников
        /// </summary>
        Dictionary<int, string> SourceEnumDict { get; set; }

        /// <summary>
        /// Словарь локализаций
        /// </summary>
        Dictionary<int, string> LanguageEnumDict { get; set; }
    }
}
