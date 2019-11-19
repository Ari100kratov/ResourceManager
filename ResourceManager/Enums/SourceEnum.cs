using System;
using System.Collections.Generic;
using System.Linq;

namespace ResourceManager
{
    /// <summary>
    /// Перечесление источника данных
    /// </summary>
    public enum SourceEnum
    {
        /// <summary>
        /// Клиент
        /// </summary>
        Client = 0,

        /// <summary>
        /// Сервер
        /// </summary>
        Server = 1
    }

    /// <summary>
    /// Расширения для перечисления
    /// </summary>
    public static class SourceEnumExtension
    {
        /// <summary>
        /// Возвращает список перечисления источников как словарь
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, string> GetSourceEnumDict()
        {
            return Enum.GetValues(typeof(SourceEnum))
                .Cast<SourceEnum>()
                .ToDictionary(x => (int)x, x => x.ToLocalString());
        }

        /// <summary>
        /// В соответствии с локализацией
        /// </summary>
        /// <param name="source">Перечисление источника</param>
        /// <returns></returns>
        public static string ToLocalString(this SourceEnum source)
        {
            switch (source)
            {
                case SourceEnum.Client:
                    return ProjectResource.SourceEnumExtension_ToLocalString_Client;

                case SourceEnum.Server:
                    return ProjectResource.SourceEnumExtension_ToLocalString_Server;

                default:
                    return "";
            }

        }
    }

}
