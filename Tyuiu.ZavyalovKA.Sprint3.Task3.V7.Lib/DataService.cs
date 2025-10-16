﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZavyalovKA.Sprint3.Task3.V7.Lib
{
    public class DataService : ISprint3Task3V7
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string result = "";
            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    result += replacement;
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}