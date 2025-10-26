﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZavyalovKA.Sprint3.Task4.V5.Lib
{
    public class DataService : ISprint3Task4V5
    {
        double ISprint3Task4V5.Calculate(int startValue, int stopValue)
        {
            {
                double res = 0;
                for (int i = startValue; i <= stopValue; i++)
                {
                    if (i == 0)
                    {
                        break;
                    }
                    else
                    {
                        res = res + (Math.Cos(i) - Math.Sin(i)) / i;
                    }
                }
                return Math.Round(res, 3);
            }
        }
    }
}
