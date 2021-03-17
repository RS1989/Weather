namespace MD.WeatherConverter
{
    public interface IConverterService
    {
        double Get(string unit, double temp);
    }
}