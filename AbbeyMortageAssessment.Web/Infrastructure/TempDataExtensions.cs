﻿using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace AbbeyMortageAssessment.Web.Infrastructure
{
    public static class TempDataExtensions
    {
        public static void Set<T>(this ITempDataDictionary tempData, string key, T value)
        {
            string json = JsonConvert.SerializeObject(value);
            tempData.Add(key, json);
        }

        public static T Get<T>(this ITempDataDictionary tempData, string key)
        {
            if (!tempData.ContainsKey(key)) return default;

            var value = tempData[key] as string;

            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
