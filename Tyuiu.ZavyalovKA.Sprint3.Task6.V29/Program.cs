// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint3.Task6.V29.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
int startValue = 12;
int stopValue = 18;
Console.WriteLine("Начало отрезка = " + startValue);
Console.WriteLine("Конец отрезка = " + stopValue);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
Console.ReadKey();
