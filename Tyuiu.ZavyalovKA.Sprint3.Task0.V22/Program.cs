// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint3.Task0.V22.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
double value = 0.25;
int startValue = 1;
int stopValue = 8;
Console.WriteLine("Переменная x = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Стоп шага = " + stopValue);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
Console.ReadKey();


