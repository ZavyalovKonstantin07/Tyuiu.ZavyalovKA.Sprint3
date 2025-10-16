// See https://aka.ms/new-console-template for more information
using Tyuiu.ZavyalovKA.Sprint3.Task3.V7.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
string value = "gft hggt ntg";
char replaceable = 'g';
char replacement = '4';
Console.WriteLine("Исходная строка: " + value);
Console.WriteLine("Буква, которую нужно заменить: " + replaceable);
Console.WriteLine("На что заменить: " + replacement);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Итоговая строка: " + ds.ReplaceCharOnNum(value, replaceable, replacement));
Console.ReadKey();