using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MD.Weather.Services
{    public static class ConfigurationService
    {
        public static T BindValue<T>(this IConfiguration configuration, string key) where T : new()
        {
            var value = new T();
            configuration.Bind(key, value);
            return value;
        }

    }
}
