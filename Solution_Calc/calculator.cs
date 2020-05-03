using System;

namespace Solution_Calc
{
    class Calculator
    {
        static void Main(string[] args)
        {
            bool teste;
            int num = 2;
            teste = (num & 8) != 0;
            Console.WriteLine(teste);
            Console.ReadLine();
        }
    }
}
