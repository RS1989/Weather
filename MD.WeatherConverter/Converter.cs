using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.WeatherConverter
{
    public class Converter
    {
        private Temperature _temperature;

        public Converter(Temperature temperature)
        {
            _temperature = temperature;
        }

        public double Convert(double value)
        {
            return _temperature.GetTemp(value);
        }
    }
}
