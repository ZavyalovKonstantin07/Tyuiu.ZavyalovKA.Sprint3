// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint3.Task7.V27.Lib;

namespace Tyuiu.ZavyalovKA.Sprint3.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("******************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:          *");
            Console.WriteLine("******************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);
            int len = valueArray.Length;

            Console.WriteLine("******************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                *");
            Console.WriteLine("******************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   F(X)   |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("|{0,5}     | {1,7:f2}  |", startValue + i, valueArray[i]);
            }

            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}