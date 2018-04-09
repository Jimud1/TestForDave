using Newtonsoft.Json;

namespace Utilities
{
    public static class JsonModelHelper
    {
        /// <summary>
        /// Convert Josn to model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T JsonToModel<T>(string json)
        {
            //Ignore null values
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            return JsonConvert.DeserializeObject<T>(json, settings);
        }
    }
}