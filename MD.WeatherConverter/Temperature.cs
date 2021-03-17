using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.WeatherConverter
{
    public abstract class Temperature
    {
        public abstract double GetTemp(double tempK);
    }
}
