// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint3.Task1.V18.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
int startValue = 1;
int stopValue = 15;
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Стоп шага = " + stopValue);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(startValue, stopValue));
Console.ReadKey();
