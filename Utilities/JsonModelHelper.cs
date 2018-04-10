using Newtonsoft.Json;
using System;

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
            T model;
            //Ignore null values
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            try
            {
                model = JsonConvert.DeserializeObject<T>(json, settings);
            }
            catch(Exception ex)
            {
                throw new Exception($"An error occured trying to convert {json} into {typeof(T)}", ex);
            }

            return model;
        }
    }
}