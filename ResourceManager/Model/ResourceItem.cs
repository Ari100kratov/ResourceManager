
namespace ResourceManager.Model
{
    /// <summary>
    /// Элемент ресурса
    /// </summary>
    public class ResourceItem
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="value">Значение</param>
        public ResourceItem(string key, string value)
        {
            this.Key = key;
            this.CurrentValue = value;
        }

        /// <summary>
        /// Ключ
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        /// Текущее значение
        /// </summary>
        public string CurrentValue { get; private set; }

        /// <summary>
        /// Новое значение
        /// </summary>
        public string NewValue { get; set; }
    }
}
