﻿namespace Napilnik1
{
    class ExampleTask1
    {
        public static int ReturnValidNumber(int a, int b, int c)
        {
            if (a < b)
                return b;
            else if (a > c)
                return c;
            else
                return a;
        }
    }
}
