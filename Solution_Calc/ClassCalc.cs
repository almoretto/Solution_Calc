using System;
using System.Collections.Generic;
using System.Data;
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
                    return "Resto da divisão de " + a + " por " + b + "é: " + Resultado.ToString("F2") + "\n" + "Portanto não são divisíveis!";
                }
            }
        }
        public string ParImpar(int num)
        {
            //	5. Write an expression that checks whether an integer is odd or even.

            Resultado = num % 2;
            if (Resultado == 0)
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
            if (Resultado == chek)
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
            if (c == 'A' || c == 'a')
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

        public double Trapezio(double baseA, double baseB, char c, double alturaH = 0.0, double ladoC = 0.0, double ladoD = 0.0)
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
            Resultado = peso * 0.17;
            return Resultado;
        }
        public string VerificarCoordenadaNaAreaCirculo(int x, int y, double r, int x1 = 0, int y1 = 0)
        {

            if ((x1 == 0) && (y1 == 0))
            {
                Resultado = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (Resultado <= r)
                {
                    return "O ponto P{"
                        + x
                        + ","
                        + y
                        + "} está dentro da circunferência de centro k{0,0] e Raio 5";
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
            else
            {
                Auxiliar = Math.Sqrt(Math.Pow((x - x1), 2) + Math.Pow((y - y1), 2));
                if (Auxiliar <= r)
                {
                    return "O ponto P{"
                        + x
                        + ","
                        + y
                        + "} está dentro da circunferência de centro k{0,0] e Raio 5";
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
        public string VerificarCoordenadaNaAreaRetCirc(int x, int y, double r, int x1 = 0, int y1 = 0)
        {
            /* Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) 
             * and out of the rectangle [{-1, 1}, {5, 5}]. 
             * Clarification: for the rectangle the lower left and the upper right corners are given. 
             */
            if ((x1 == 0) && (y1 == 0))
            {
                Resultado = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if ((Resultado <= r) && (y < 1 || x < -1))
                {

                    return "O ponto P{"
                        + x
                        + ","
                        + y
                        + "} está dentro da circunferência de centro k{0,0] e Raio 5"
                        + "e fora do retângulo posição LL{-1,1} e UR{5,5}";
                }
                else
                {
                    return "O ponto P{"
                        + x
                        + ","
                        + y
                        + "} está fora da circunferência de centro k{0,0] e Raio 5."
                        + " Ou dentro do retângulo";
                }
            }
            else
            {
                Auxiliar = Math.Sqrt(Math.Pow((x - x1), 2) + Math.Pow((y - y1), 2));
                if ((Auxiliar <= r) && (y < 1 || x < -1))
                {
                    return "O ponto P{"
                        + x
                        + ","
                        + y
                        + "} está dentro da circunferência de centro k{0,0] e Raio 5"
                        + "e fora do retângulo posição LL{-1,1} e UR{5,5}";
                }
                else if (((Auxiliar <= r) && (y > 5 || x > 5)))
                {
                    return "O ponto P{"
                        + x
                        + ","
                        + y
                        + "} está dentro da circunferência de centro k{0,0] e Raio 5"
                        + "e fora do retângulo posição LL{-1,1} e UR{5,5}";
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
        public string QuatroDigitos(int a, int b, int c, int d)
        {
            /*Write a program that takes as input a four-digit number in format abcd(e.g. 2011) 
           * and performs the following actions: 
           * Calculates the sum of the digits(in our example 2+0+1+1 = 4). 
           * Prints on the console the number in reversed order: dcba(in our example 1102). 
           * Puts the last digit in the first position: dabc(in our example 1201). 
           * Exchanges the second and the third digits: acbd(in our example 2101). 
           */
            Resultado = a + b + c + d;

            return "A Soma dos 4 digitos é: "
                + Resultado
                + ", ordem invertida: "
                + d + c + b + a
                + ", ultimo em primeiro: "
                + d + a + b + c
                + ", troca segundo e terceiro: "
                + a + c + b + d;

        }
        
    }
}
