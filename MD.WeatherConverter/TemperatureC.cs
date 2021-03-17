using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.WeatherConverter
{
    public class TemperatureC: Temperature
    {
        public override double GetTemp(double tempK)
        {
            return tempK - 273;
        }
    }
}
