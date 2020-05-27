using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamanhoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1;
            string frase2;
            int tamanho1;
            int tamanho2;

            Console.WriteLine("Digite uma frase: ");
            frase1 = Console.ReadLine();

            Console.WriteLine("Digite outra frase: ");
            frase2 = Console.ReadLine();

            Console.Clear();

            tamanho1 = frase1.Length;
            tamanho2 = frase2.Length;

            Console.WriteLine("Primeira frase: " + frase1);
            Console.WriteLine("Segunda frase " + frase2 + "\n");

            Console.WriteLine("A frase '" + frase1 + "' tem o tamanho de: " + tamanho1 + " caracteres.");
            Console.WriteLine("A frase '" + frase2 + "' tem o tamanho de: " + tamanho2 + " caracteres.\n");

            Tamanhos(tamanho1, tamanho2);
            Frases(frase1, frase2);

            Console.ReadLine();
        }

        public static void Tamanhos(int tamanho1, int tamanho2)
        {
            if (tamanho1 == tamanho2)
                Console.WriteLine("As duas frases sao de tamanhos iguais");
            else
                Console.WriteLine("As duas frases sao de tamanhos diferentes");
        }

        public static void Frases(string frase1, string frase2)
        {
            if (frase1 == frase2)
                Console.WriteLine("As duas frases possuem conteudos iguais");
            else
                Console.WriteLine("As duas frases possuem conteudos diferentes");
        }
    }
}
