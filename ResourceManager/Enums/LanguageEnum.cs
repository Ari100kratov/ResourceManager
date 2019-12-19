using System;
using System.Collections.Generic;
using System.Linq;

namespace ResourceManager.Enums
{
    /// <summary>
    /// Перечесление локализаций
    /// </summary>
    public enum LanguageEnum
    {
        /// <summary>
        /// Русский
        /// </summary>
        ru = 0,

        /// <summary>
        /// Английский
        /// </summary>
        en = 1,

        /// <summary>
        /// Китайский
        /// </summary>
        zh = 2,

        /// <summary>
        /// Французский
        /// </summary>
        fr = 3,

        /// <summary>
        /// Немецкий
        /// </summary>
        de = 4,

        /// <summary>
        /// Итальянский
        /// </summary>
        it = 5,

        /// <summary>
        /// Корейский
        /// </summary>
        ko = 6
    }

    /// <summary>
    /// Расширения для перечисления
    /// </summary>
    public static class LanguageEnumExtension
    {
        /// <summary>
        /// Возвращает список перечисления локализация как словарь
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, string> GetLanguageEnumDict()
        {
            return Enum.GetValues(typeof(LanguageEnum))
                .Cast<LanguageEnum>()
                .ToDictionary(x => (int)x, x => x.ToLocalString());
        }

        /// <summary>
        /// Возвращает строку для отображения
        /// </summary>
        /// <param name="source">Перечисление локализаций</param>
        /// <returns></returns>
        public static string ToLocalString(this LanguageEnum lang)
        {
            switch (lang)
            {
                case LanguageEnum.ru: return "Русский";
                case LanguageEnum.en: return "English";
                case LanguageEnum.zh: return "中文";
                case LanguageEnum.fr: return "Francais";
                case LanguageEnum.de: return "Deutsch";
                case LanguageEnum.it: return "Italiano";
                case LanguageEnum.ko: return "한국인";

                default: return "en";
            }
        }

        /// <summary>
        /// Возвращает путь к ресурсам данной локализации
        /// </summary>
        /// <param name="source">Перечисление локализации</param>
        /// <returns></returns>
        public static string ToPathString(this LanguageEnum lang)
        {
            switch (lang)
            {
                case LanguageEnum.ru: return "ru";
                case LanguageEnum.en: return "en";
                case LanguageEnum.zh: return "zh-CN";
                case LanguageEnum.fr: return "fr";
                case LanguageEnum.de: return "de";
                case LanguageEnum.it: return "it";
                case LanguageEnum.ko: return "ko";

                default: return "en";
            }
        }
    }
}
