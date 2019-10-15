using System;
using POO_PortasLogicas;

namespace ULA {
    class Program {
        static void Main(string[] args) {
            POO_PortasLogicas.And2 and = new POO_PortasLogicas.And2();
            and.setBit1(1);
            and.setBit2(0);
            Console.WriteLine("Hello World!");
            Console.WriteLine(and.getBit1());
            Console.WriteLine(and.getBit2());

            int numA, numB, operacao;
            int[] A, B, op, resultado;
            char rep;
            do
            {
                Console.Clear();
                do
                {
                    Console.Write("Insira um 0 ou 1 para A: ");
                } while (!int.TryParse(Console.ReadLine(), out numA) && (numA <= 0 || numA >= 1));

                do
                {
                    Console.Write("Insira 0 ou 1 para B: ");
                } while (!int.TryParse(Console.ReadLine(), out numB) && (numA <= 0 || numA >= 1));

                Console.Clear();
                Console.WriteLine("A: " + numA.ToString() + " | B: " + numB.ToString());
                Console.Write("\n\nA and B (0)\nA or B (1)\nA xor B (2)\nA' (3)\nB' (4)\nA + B" + "\n\nEscolha a operação: ");
                while (!int.TryParse(Console.ReadLine(), out operacao) && (operacao < 0 || operacao > 4)) ;

                Console.Clear();
                Console.WriteLine("A: " + numA.ToString() + " | B: " + numB.ToString());
               
                do
                {
                    Console.Write("\n\nDeseja continuar? (s/n)");
                } while (char.TryParse(Console.ReadLine().ToLower(), out rep) && (!rep.Equals('s') && !rep.Equals('n')));

            } while (rep.Equals('s'));


        }
    }
    }

