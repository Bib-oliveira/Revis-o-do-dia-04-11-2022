using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_LP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção;
            double cateto1, cateto2, Hipotenusa, area, altura, peso, IMC;
            Console.Clear();
            Console.WriteLine("Selçecione a atividade desejada");
            Console.WriteLine("1- Atividade do combustível");
            Console.WriteLine("2- Média dos 50 numeros");
            Console.WriteLine("3- Area de um triangulo retangulo");
            Console.WriteLine("4- calculo de IMC");
            Console.WriteLine("5- Notas dos alunos");
            opção = Convert.ToInt32(Console.ReadLine());

            if (opção == 1)
            {



            }

            else if (opção == 2)
            {




            }

            else if (opção == 3)
            {
                Console.Clear();
                Console.WriteLine("Insira o valor do primeiro cateto");
                cateto1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Insira o valor do segundo cateto");
                cateto2 = Convert.ToDouble(Console.ReadLine());

                Hipotenusa = cateto1 + cateto2;
                area = (cateto1 * cateto2) /2;

                Console.WriteLine("Valor da Hipotenusa é " + Hipotenusa);
                Console.WriteLine("Valor da área é " + area);

            }

            else if (opção == 4)
            {
                Console.WriteLine("Calculo de IMC");
                Console.WriteLine("Escreva sua altura");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escreva o seu peso");
                peso = Convert.ToDouble(Console.ReadLine());

                IMC = peso / (altura * altura);



                if(IMC <= 18.5)
                {
                    Console.Clear();
                    Console.WriteLine(IMC);
                    Console.WriteLine("Você está abaixo do peso");

                }

                else if(IMC >= 18.6 && IMC <= 24.9)
                {
                    Console.Clear();
                    Console.WriteLine(IMC);
                    Console.WriteLine("Você está no peso ideal, parabéns!");
                }
                else if(IMC >= 25.0 && IMC <= 29.9)
                {
                    Console.Clear();
                    Console.WriteLine(IMC);
                    Console.WriteLine("Você está levemente acima do peso");

                }
                else if(IMC >= 30.0 && IMC <= 34.9)
                   {
                    Console.Clear();
                    Console.WriteLine(IMC);
                    Console.WriteLine("Você está com obesidade grau 1");

                }
                else if(IMC >= 35.0 && IMC <= 39.9)
                {
                    Console.Clear();
                    Console.WriteLine(IMC);
                    Console.WriteLine("Você está com obesidade grau 2 (Severa)");

                }
                else if (IMC >= 40)
                {
                    Console.Clear();
                    Console.WriteLine(IMC);
                    Console.WriteLine("Você está com obesidade grau 3 (Mórbida)");

                }
                

            }

            else if (opção == 5)
            {




            }
            Console.ReadKey();
        }
    }
}
