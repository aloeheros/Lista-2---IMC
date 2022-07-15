using System;

namespace imc_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu peso: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());



            float imc = peso / (altura * altura);


        }
    }
}