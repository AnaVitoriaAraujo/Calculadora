using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ModelCalculadora
    {
        //declarando variaveis
        private double num1;
        private double num2;

        public ModelCalculadora() //metodo contrutor que deve ter o memo nome da classe
        {
            GetSetNum1 = 0; //tinha o this. mas trocou pelo nome do encapsulamento getsetnum1
            GetSetNum2 = 0;
        }//fim do contrutor

        //get e set
        public double GetSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }//fim do get set num1

        public double GetSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; } //valor é o que você vai digitar
        }

        //Metodos

        public double Somar()
        {
            return GetSetNum1 + GetSetNum2;
        }//fim do metodo somar

        public double Subtrair()
        {
            return GetSetNum1 - GetSetNum2;
        }//fim do metodo subtrair

        public double Dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;
            }                
            else
            {
                return GetSetNum1 / GetSetNum2;
            }            
        }//fim do metodo dividir

        public double Multiplicar()
        {
            return GetSetNum1 * GetSetNum2;
        }//fim do multiplicar

        public double Potencia()
        {
            return Math.Pow(GetSetNum1, GetSetNum2); //  o math é a biblioteca de simbolos matematicos
        }//fim da potencia

        public string Raiz() // não ha dois returns
        {
            string msg = "Raiz do primeiro numero" + Math.Sqrt(GetSetNum1) +
                "\nRaiz do segundo numero" + Math.Sqrt(GetSetNum2);
            return msg; //use o msg para não usar o console
        }//fim da Raiz

        public string TabuadaNum1() //senao fosse string ele não exibiria o resultado
        {
            string resultado = "";
            for(int i = 0; i <=10; i++) // o i ++ e a cada volta dor for ele conta mais um
            {
                resultado += "\n" + GetSetNum1 + "*" + i + "=" + (GetSetNum1 * i);
            }// += pra ficar na mesma variavel

            return resultado; 
        }//fim da tabuada


        public string TabuadaNum2() //senao fosse string ele não exibiria o resultado
        {
            string resultado = "";
            // o for é o inicio o fim e de quqanto em quanto ele dara passos
            for (int i = 0; i <= 10; i++) // o i ++ e a cada volta dor for ele conta mais um
            {
                resultado += "\n" + GetSetNum2 + "*" + i + "=" + (GetSetNum1 * i);
            }// += pra ficar na mesma variavel

            return resultado;
        }//fim da tabuada

        public string DecimalBinario()
        {
            int GetSetNum1 = 0;
            string numBinario = "";

            Console.WriteLine("Converta um numero decimal para binario");
            Console.WriteLine("Informe um numero");
            GetSetNum1 = Convert.ToInt32(Console.ReadLine());

            while (GetSetNum1 / 2 >= 1)
            {
                numBinario = Convert.ToString(GetSetNum1 % 2) + numBinario;


                GetSetNum1 = GetSetNum1 / 2;
            }
            numBinario = Convert.ToString(GetSetNum1) + numBinario;
            Console.WriteLine("A conversão é de " + numBinario);
            Console.ReadKey();
            return numBinario;

        }

       
        public int Bhaskara()
        {
            int X1;
            int X2;
            Console.WriteLine("Informe o valor de A: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de b");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de c");
            int C = int.Parse(Console.ReadLine());

            int delta = (B ^ 2) - 4 * A * C;

            Console.WriteLine("O valor de delta é: " + delta);

            if (delta > 0)
            {
                Console.WriteLine("Impossivel calcular esta raiz");
            }

            X1 = ((-B + delta) / (2 * A));
            X2 = ((-B - delta) / (2 * A));
            Console.WriteLine("X1 é: "+ X1);
            Console.WriteLine("X2 é: "+ X2);

            return X1;
        }

        public static string ReverteString(string str)
        {
            return new string(str.Reverse().ToArray());
        }//fim do reverte string

        public static int BinarioDecimal(string numBinario)
        {
            int expoente = 0;
            int numero;
            int soma = 0;                                                           
            string numeroInvertido = ReverteString(numBinario);                                         
            for (int i = 0; i < numeroInvertido.Length; i++)
            {
                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));
                soma += numero * (int)Math.Pow(2, expoente);
                expoente++;
            }
            return soma;
        }//fim do binario para decimal

        public string DecimalHexa()
        {
            int num_decimal = 0;
            string num_hexadecimal;

            Console.WriteLine("Informe um numero em decimal : ");
            num_decimal = int.Parse(Console.ReadLine());

            string an = num_hexadecimal = num_decimal.ToString("X");
            return an;
        }

        //nunca por console.writeLine na model
    }//fim da classe
}//fim do projeto
