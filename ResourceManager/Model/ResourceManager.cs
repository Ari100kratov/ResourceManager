using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using Mono.Cecil;
using ResourceManager.Enums;

namespace ResourceManager.Model
{
    /// <summary>
    /// Менеджер ресурсов
    /// </summary>
    public class ResourceManager : IResourceManager
    {
        #region Const

        /// <summary>
        /// Путь к проекту по умолчанию
        /// </summary>
        private readonly string PROJECT_DEFAULT_PATH = Settings.Default.ProjectDefaultPath;

        #endregion

        #region Fields

        /// <summary>
        /// Модуль сборки
        /// </summary>
        private AssemblyDefinition _assemblyModule;

        #endregion

        #region Properties

        /// <summary>
        /// Полный путь к библиотеке ресурсов
        /// </summary>
        public string LibraryFullPath => Path.Combine
            (string.IsNullOrWhiteSpace(this.ProjectPath)
            ? this.PROJECT_DEFAULT_PATH
            : this.ProjectPath
            , this.CurrentSourceEnum.ToPathString()
            , this.Language);

        /// <summary>
        /// Путь к проекту
        /// </summary>
        public string ProjectPath
        {
            get
            {
                return string.IsNullOrWhiteSpace(Settings.Default.ProjectPath)
                    ? Settings.Default.ProjectDefaultPath
                    : Settings.Default.ProjectPath;
            }
            set => Settings.Default.ProjectPath = Path.Combine(value);
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public string Language
        {
            get
            {
                return string.IsNullOrWhiteSpace(Settings.Default.Language)
                    ? "ru"
                    : Settings.Default.Language;
            }
            set
            {
                Settings.Default.Language = value;
            }
        }

        /// <summary>
        /// Текущий источник ресурсов
        /// </summary>
        public SourceEnum CurrentSourceEnum { get; set; }

        public LanguageEnum CurrentLanguageEnum { get; set; }

        #endregion

        #region GetList

        /// <summary>
        /// Возвращает список библиотек
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetLibraryList()
        {
            if (!Directory.Exists(this.LibraryFullPath))
                return new List<string>();

            return Directory.GetFiles(this.LibraryFullPath)
                .Where(x => !x.Contains("DevExpress")).ToList();
        }

        /// <summary>
        /// Возвращает список ресурсов выбранной библиотеки
        /// </summary>
        /// <param name="libraryPath">Путь к месторасположению библиотеки</param>
        /// <returns></returns>
        public IEnumerable<string> GetResourceList(string libraryPath)
        {
            this.FillAssemblyModule(libraryPath);

            if (this._assemblyModule == null)
                return new List<string>();

            return this._assemblyModule.MainModule.Resources.Select(x => x.Name).ToList();
        }

        /// <summary>
        /// Возвращает список элементов выбранного ресурса
        /// </summary>
        /// <param name="resourceName">Наименование выбранного ресурса</param>
        /// <returns></returns>
        public IEnumerable<ResourceItem> GetResourceItemlist(string resourceName)
        {
            var resourceItemList = new List<ResourceItem>();

            if (string.IsNullOrWhiteSpace(resourceName))
                return resourceItemList;

            //Получаем ресурс
            var resource = this._assemblyModule?.MainModule?.Resources.FirstOrDefault(x => x.Name.Equals(resourceName));

            if (resource == null)
                return resourceItemList;

            var resourceStream = (resource as EmbeddedResource).GetResourceStream();
            var resourceReader = new ResourceReader(resourceStream);

            foreach (DictionaryEntry dictEntry in resourceReader)
            {
                var resourceItem = new ResourceItem(dictEntry.Key.ToString(), dictEntry.Value.ToString());
                resourceItemList.Add(resourceItem);
            }

            return resourceItemList;
        }

        #endregion

        #region Fill Assembly

        /// <summary>
        /// Заполнение модуля сборки
        /// </summary>
        /// <param name="libraryPath">Путь к месторасположению библиотеки</param>
        private void FillAssemblyModule(string libraryPath)
        {
            //Освобождаем ресурсы перед заполнением
            this._assemblyModule?.Dispose();

            if (string.IsNullOrWhiteSpace(libraryPath))
                return;

            //Заполняем ресурсы библиотеки
            this._assemblyModule = AssemblyDefinition.ReadAssembly(libraryPath, new ReaderParameters { ReadWrite = true });
        }

        #endregion

        #region Save

        /// <summary>
        /// Генерация измененного ресурса
        /// </summary>
        /// <param name="resourceItemList">Список измененных элементов ресурса</param>
        /// <returns>Поток</returns>
        private Stream GenerateResource(IEnumerable<ResourceItem> resourceItemList)
        {
            //Временный поток для записи и копирования в результирующий поток
            var tempStream = new MemoryStream();

            //Результирующий поток
            var resultStream = new MemoryStream();

            using (var resourceWriter = new ResourceWriter(tempStream))
            {
                foreach (var resourceItem in resourceItemList)
                {
                    var value = string.IsNullOrWhiteSpace(resourceItem.NewValue)
                        ? resourceItem.CurrentValue
                        : resourceItem.NewValue;

                    resourceWriter.AddResource(resourceItem.Key, value);
                }

                resourceWriter.Generate();

                //Перед копированием обнуляем позицию потока
                tempStream.Position = 0;
                tempStream.CopyTo(resultStream);
            }

            //После копирования также обнуляем позицию потока
            resultStream.Position = 0;
            return resultStream;
        }

        /// <summary>
        /// Сохранение изменений
        /// </summary>
        /// <param name="resourceName">Выбранный ресурс</param>
        /// <param name="resourceItemList">Измененый список элементов ресурса</param>
        public void SaveChanges(string resourceName, IEnumerable<ResourceItem> resourceItemList)
        {
            if (this._assemblyModule == null)
                return;

            var resourceItemIndex = this._assemblyModule.MainModule.Resources.FindIndex(x => x.Name.Equals(resourceName));

            if (resourceItemIndex == -1)
                return;

            //Удаляем ресурс в сборке
            this._assemblyModule.MainModule.Resources.RemoveAt((int)resourceItemIndex);

            //Получаем поток измененых элементов ресурса
            var resourceStream = this.GenerateResource(resourceItemList);

            //Генерируем новый ресурс из полученного потока
            var embeddedResource = new EmbeddedResource(resourceName, ManifestResourceAttributes.Public, resourceStream);

            //Добавляем сгенерированный ресурс
            this._assemblyModule.MainModule.Resources.Add(embeddedResource);

            this._assemblyModule.Write();
            this._assemblyModule.Dispose();
        }

        #endregion
    }
}
