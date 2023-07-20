using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public double DecimalBinario()
        {
            
            return (GetSetNum1 % 2);
            
        }


        //nunca por console.writeLine na model
    }//fim da classe
}//fim do projeto
