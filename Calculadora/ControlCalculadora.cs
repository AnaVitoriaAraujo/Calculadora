using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    //use voids e write line na control
    class ControlCalculadora
    {
        ModelCalculadora calculadora;//criado um obejeto calculadora na memoria

        public ControlCalculadora()
        {
            // o this é diferencia que não é uma variavel
            this.calculadora = new ModelCalculadora();
        }//fim do contrutor

        public void Coletar()
        {
            // esse ponto debaixo separa a chave q é a calucladora do metodo
            Console.WriteLine("Informe um numero: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro numero: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletar

        public int Menu()
        {
            Console.WriteLine("-------Menu-------" +
                "\n0. Sair" +
                "\n1. Somar" +
                "\n2. Subtrair" +
                "\n3. Dividir" +
                "\n4. Multiplicar" +
                "\n5. Potencia" +
                "\n6. Raiz" +
                "\n7. Tabuada" +
                "\n9. Converta decimal para binario" +
                "\n10. Converta binario para decimal" +
                "\n11. Converta decimal para hexadecimal"+
                "\n12. Converta hexadecimal para decimal"+
                "\nEscolha uma das opcoes acima");

            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao; // precisa do return pra saber a opcao escolhida
        }//fim do metodo Menu

        public void Operacao()
        {
            int opcao = -1;
            do
            {

                opcao = Menu();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigada!");
                        break;

                    case 1:

                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;

                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração" + this.calculadora.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("Impossivel dividir");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;

                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;

                    case 5:
                        Coletar();
                        Console.WriteLine("Potencia :" + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;

                    case 7:
                        Console.WriteLine("informe um numero");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;

                    case 8:
                        Console.WriteLine("informe um numero");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;

                    case 9:
                        Coletar();
                        Console.WriteLine("Informe um numero que deseja tranformar em binario " + this.calculadora.DecimalBinario());
                        break;

                    default:
                        Console.WriteLine("Opção escolhida não é valida");
                        break;

                }//fim do switch

            }while (opcao != 0);
            
        }//fim da operação
    }//fim da classe
}//fim do projeto
