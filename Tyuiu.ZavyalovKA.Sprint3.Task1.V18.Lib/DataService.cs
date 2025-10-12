using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZavyalovKA.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double SumSeries = 1;
            while (startValue <= stopValue)
            {
                SumSeries += (Math.Sin(startValue) * Math.Pow(0.25, 2));
                startValue++;
            }
            return Math.Round(SumSeries, 3);
        }
    }
}

