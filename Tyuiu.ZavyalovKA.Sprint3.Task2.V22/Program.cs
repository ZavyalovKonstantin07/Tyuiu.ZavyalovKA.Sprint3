// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint3.Task2.V22.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
int value = 5;
int startValue = 1;
int stopValue = 7;
Console.WriteLine("Переменная X = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Произведение ряда равно " + ds.GetMultiplySeries(value, startValue, stopValue));
Console.ReadKey();
