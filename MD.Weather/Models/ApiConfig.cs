using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MD.Weather.Models
{
    public class ApiConfig
    {
        public string Url { get; set; }
        public string Key { get; set; }
        public List<string> ParameterName { get; set; }
    }
}
