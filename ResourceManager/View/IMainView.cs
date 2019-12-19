using ResourceManager.Enums;
using ResourceManager.Model;
using ResourceManager.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManager.View
{
    /// <summary>
    ///  Интерфейс вида
    /// </summary>
    public interface IMainView
    {
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

    }
}
