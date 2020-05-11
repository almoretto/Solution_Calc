using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Solution_Calc
{
    class ClassCalc
    {
        private double Resultado;
        private double Auxiliar;
        private bool Teste;
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
        public string Dividir(double a, double b)
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
                if (Resultado == 0)
                {
                    return a + " é divisível! por " + b;
                }
                else
                {
                    return "Resto da divisão de " + a + " por " + b + "é: " + Resultado.ToString("F2")+"\n"+"Portanto não são divisíveis!";
                }
            }
        }
        public string ParImpar(int num)
        {
            //	5. Write an expression that checks whether an integer is odd or even.

            Resultado = num % 2;
            if (Resultado==0)
            {
                return "Par";
            }
            else
            {
                return "Impar";
            }
        }
        public string ChecarCentena(int num, int chek)
        {
            Auxiliar = num / 100;
            Auxiliar /= 10;
            Resultado = Auxiliar % 10;
            if (Resultado==chek)
            {
                return "Centena é: " + Resultado;
            }
            else
            {
                return "Não é igual ao número solicitado.";
            }
        }
        public int BinarioTercPos(int n)
        {
            Teste = (n & 8) != 0;
            if (Teste)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public double Quadrilatero(double lado, double altura, char c)
        {
            if (c=='A'||c=='a')
            {
                Resultado = lado * altura;
                return Resultado;
            }
            else if (c == 'P' || c == 'p')
            {
                Resultado = (2 * lado) + (2 * altura);
                return Resultado;
            }
            else
            {
                Console.WriteLine("Cálculo não implementado");
                return 0.0;
            }
        }

        public double Trapezio(double baseA, double baseB, char c, double alturaH=0.0, double ladoC=0.0, double ladoD=0.0)
        {
            c = char.ToUpper(c);
            switch (c)
            {
                case 'A':
                    Resultado = (baseA + baseB) * (alturaH / 2);
                    break;
                case 'P':
                    Resultado = baseA + baseB + ladoC + ladoD;
                    break;
            }
            return Resultado;
        }
        public double PesoLunar(double peso)
        {
            Resultado=peso*0.17;
            return Resultado;
        }
        public string VerificarCoordenadaNaArea(int x, int y)
        {
            Resultado = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (Resultado<=5)
            {
                return "O ponto P{"
                    +x
                    +","
                    +y
                    +"} está dentro da circunferência de centro k{0,0] e Raio 5";
            }
            else
            {
                return "O ponto P{"
                    + x
                    + ","
                    + y
                    + "} está fora da circunferência de centro k{0,0] e Raio 5";
            }
        }
    }
}
