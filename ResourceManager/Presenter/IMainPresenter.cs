using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManager.Presenter
{
    /// <summary>
    ///  Интерфейс представления
    /// </summary>
    public interface IMainPresenter
    {
        /// <summary>
        ///  Событие изменения выбранной библиотеки
        /// </summary>
        void SelectedLibraryChange();

        /// <summary>
        ///  Событие изменения выбранного ресурса
        /// </summary>
        void SelectedResourceChange();

        /// <summary>
        ///  Событие изменения выбранного каталога ресурсов
        /// </summary>
        void SelectedPathChange();

        /// <summary>
        ///  Событие изменения выбранного источника
        /// </summary>
        void SelectedSourceChange();

        /// <summary>
        ///  Сохранение изменений
        /// </summary>
        void SaveChanges();

        /// <summary>
        ///  Создание резервной копии
        /// </summary>
        void CreateBackup();

        /// <summary>
        ///  Событие загрузки формы
        /// </summary>
        void Show();

        /// <summary>
        ///  Событие загрузки формы
        /// </summary>
        void Close();
    }
}
