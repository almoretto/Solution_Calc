using System;
using System.Collections.Generic;
using System.Text;

namespace Solution_Calc
{
    class ClassCalc
    {
        private double Resultado;
        public double Somar(double a, double b)
        {
            return a + b;

        }
        public string Subtrair(double a, double b)
        {
            Resultado = a - b;
            return Resultado.ToString("F2");
        }
        public string Multiplicar(double a, double b)
        {
            Resultado = a * b;
            return Resultado.ToString("F2");
        }
        public string Dividir (double a, double b)
        {
            if (b == 0)
            {
                return "Não existe divisão por 0";
            }
            else
            {
                Resultado = a / b;
                return Resultado.ToString("F2");
            }
        }
        public string VerificaDivisor(double a, double b)
        {
            if (b == 0)
            {
                return "Não existe divisão por 0";
            }
            else
            {
                Resultado = a % b;
                return Resultado.ToString("F2");
            }
        }
        public string 
    }
}
