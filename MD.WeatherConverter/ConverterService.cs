using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.WeatherConverter
{
    public class ConverterService : IConverterService
    {
        public ConverterService()
        {

        }

        public double Get(string unit, double temp)
        {
            if (unit.ToLowerInvariant().Equals("f"))
            {
                var converterF = new Converter(new TemperatureF());
                return converterF.Convert(temp);
            }
            var converter = new Converter(new TemperatureC());
            return converter.Convert(temp);
        }
    }
}
