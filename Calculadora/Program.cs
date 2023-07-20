using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Na progman eu ligo tudo
            ControlCalculadora control = new ControlCalculadora();

            control.Operacao();
            Console.ReadLine();//manter aberto


        }//fim do metodo main
    }//fim da classe progman
}//fim do projeto calculadora
