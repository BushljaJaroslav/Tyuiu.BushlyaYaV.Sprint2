﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BushlyaYaV.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y + 800;
            res[1] = x != y + 800;
            res[2] = x < y + 801;
            res[3] = x > y + 801;
            res[4] = x <= y + 800;
            res[5] = x >= y + 801;

            return res;

        }
    }
}