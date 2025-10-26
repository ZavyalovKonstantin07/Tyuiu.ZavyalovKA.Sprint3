// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint3.Task4.V5.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
int startValue = -5;
int stopValue = 5;
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));

