﻿using System;

namespace ULA {
    class Program {
        static void Main(string[] args) {
         

            int numA = 0, numB = 0, operacao;            
            char rep;
            do
            {
                Console.Clear();
                Console.Write("\n\n(0) A and B\n(1) A or B\n(2) not A \n(3) not B \n(4) A + B" + "\n\nEscolha a operação: ");
                while (!int.TryParse(Console.ReadLine(), out operacao) && (operacao < 0 || operacao > 3)) ;

                do
                {
                    Console.Write("Insira um 0 ou 1 para A: ");
                } while (!int.TryParse(Console.ReadLine(), out numA) && (numA >= 0 && numA <= 1));

                do
                {
                    Console.Write("Insira 0 ou 1 para B: ");
                } while (!int.TryParse(Console.ReadLine(), out numB) && (numA >= 0 && numA <= 1));

                Console.Clear();
                Console.WriteLine("A: " + numA.ToString() + " | B: " + numB.ToString());

                Ula u = new Ula(numA, numB, operacao, 0);

                Console.WriteLine("O resultado é: " + u.getResult());

                do
                {
                    Console.Write("\n\nDeseja continuar? (s/n)");
                } while (char.TryParse(Console.ReadLine().ToLower(), out rep) && (!rep.Equals('s') && !rep.Equals('n')));

            } while (rep.Equals('s'));
                                          
        }
    }
}
