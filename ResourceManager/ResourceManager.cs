using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using Mono.Cecil;

namespace ResourceManager
{
    /// <summary>
    /// Менеджер ресурсов
    /// </summary>
    public class ResourceManager : IResourceManager
    {
        #region Const

        /// <summary>
        /// Путь к ресурсам клиентской части без локализации
        /// </summary>
        private readonly string RESOURCE_CLIENT_DEFAULT_PATH = Settings.Default.ResourceClientDefaultPath;

        /// <summary>
        /// Путь к ресурсам серверной части без локализации
        /// </summary>
        private readonly string RESOURCE_SERVER_DEFAULT_PATH = Settings.Default.ResourceServerDefaultPath;

        #endregion

        #region Fields

        /// <summary>
        /// Модуль сборки
        /// </summary>
        private AssemblyDefinition _assemblyModule;

        #endregion

        #region Properties

        /// <summary>
        /// Путь к библиотеке ресурсов с учетом локализации
        /// </summary>
        public string LibraryFullPath => Path.Combine(this.ProjectPath
            , this.CurrentSourceEnum == SourceEnum.Client 
            ? this.RESOURCE_CLIENT_DEFAULT_PATH 
            : this.RESOURCE_SERVER_DEFAULT_PATH
            , this.Language);

        /// <summary>
        /// Путь к проекту
        /// </summary>
        public string ProjectPath
        {
            get
            {
                //TODO: Переделать, чтобы пользователь мог положить в папку с программой - тогда берем дефолтный путь
                return string.IsNullOrWhiteSpace(Settings.Default.ProjectPath) 
                    ? "C:\\industry" 
                    : Settings.Default.ProjectPath;
            }
            set
            {
                Settings.Default.ProjectPath = Path.Combine(value);
            }
        }

        /// <summary>
        /// Локализация
        /// </summary>
        public string Language
        {
            get
            {
                //TODO: Переделать при необходимости локализации утилиты
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

        #endregion

        #region Lists

        /// <summary>
        /// Список библиотек ресурсов
        /// </summary>
        private List<string> _librarylist = new List<string>();

        /// <summary>
        /// Список ресурсов выбранной библиотеки
        /// </summary>
        private List<string> _resourceList = new List<string>();

        /// <summary>
        /// Список элементов выбранного ресурса
        /// </summary>
        private List<ResourceItem> _resourceItemList = new List<ResourceItem>();

        #endregion

        #region GetList

        /// <summary>
        /// Возвращает список библиотек
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetLibraryList()
        {
            this.FillLibraryList();

            return this._librarylist;
        }

        /// <summary>
        /// Возвращает список ресурсов выбранной библиотеки
        /// </summary>
        /// <param name="libraryPath">Путь к месторасположению библиотеки</param>
        /// <returns></returns>
        public IEnumerable<string> GetResourceList(string libraryPath)
        {
            this.FillAssemblyModule(libraryPath);
            this.FillResourceList();

            return this._resourceList;
        }

        /// <summary>
        /// Возвращает список элементов выбранного ресурса
        /// </summary>
        /// <param name="resourceName">Наименование выбранного ресурса</param>
        /// <returns></returns>
        public IEnumerable<ResourceItem> GetResourceItemlist(string resourceName)
        {
            this.FillResourceItemList(resourceName);

            return this._resourceItemList;
        }

        #endregion

        #region FillList

        /// <summary>
        /// Заполнение списка библиотек
        /// </summary>
        /// <returns></returns>
        private void FillLibraryList()
        {
            this._librarylist?.Clear();

            if (!Directory.Exists(this.LibraryFullPath))
                return;

            this._librarylist = Directory.GetFiles(this.LibraryFullPath)
                .Where(x => !x.Contains("DevExpress")).ToList();
        }

        /// <summary>
        /// Заполнение модуля сборки
        /// </summary>
        /// <param name="libraryPath">Путь к месторасположению библиотеки</param>
        private void FillAssemblyModule(string libraryPath)
        {
            if (string.IsNullOrWhiteSpace(libraryPath))
            {
                this._assemblyModule = null;
                return;
            }

            //Освобождаем ресурсы перед заполнением
            this._assemblyModule?.Dispose();

            //Заполняем ресурсы библиотеке
            this._assemblyModule = AssemblyDefinition.ReadAssembly(libraryPath, new ReaderParameters { ReadWrite = true });
        }

        /// <summary>
        /// Заполнение списка ресурсов
        /// </summary>
        private void FillResourceList()
        {
            this._resourceList?.Clear();

            if (this._assemblyModule == null)
                return;

            this._resourceList = this._assemblyModule.MainModule.Resources.Select(x => x.Name).ToList();
        }

        /// <summary>
        /// Заполнение списка элементов ресурса
        /// </summary>
        /// <param name="resourceName">Наименование выбранного ресурса </param>
        private void FillResourceItemList(string resourceName)
        {
            this._resourceItemList?.Clear();

            if (string.IsNullOrWhiteSpace(resourceName))
                return;

            //Получаем ресурс
            var resource = this._assemblyModule?.MainModule?.Resources.FirstOrDefault(x => x.Name.Equals(resourceName));

            if (resource == null)
                return;

            var resourceStream = (resource as EmbeddedResource).GetResourceStream();
            var resourceReader = new ResourceReader(resourceStream);

            foreach (DictionaryEntry dictEntry in resourceReader)
            {
                var resourceItem = new ResourceItem(dictEntry.Key.ToString(), dictEntry.Value.ToString());
                this._resourceItemList.Add(resourceItem);
            }
        }

        #endregion

        #region Save

        /// <summary>
        /// Резервное копирование данных
        /// <param name="libraryPath">Путь к библиотеке ресурсов включая наименование файла</param>
        /// </summary>
        public void CreateBackup(string libraryPath)
        {
            if (!File.Exists(libraryPath))
                return;

            var saveFileDialog = new SaveFileDialog
            {
                Title = ProjectResource.CreateBackup_Dialog_Header,
                FileName = Path.GetFileName(libraryPath)
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            File.Copy(libraryPath, saveFileDialog.FileName);
        }

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
                    var value = string.IsNullOrEmpty(resourceItem.NewValue)
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
