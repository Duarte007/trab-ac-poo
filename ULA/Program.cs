using System;

namespace ULA {
    class Program {
        static void Main(string[] args) {
         

            int numA, numB, operacao;            
            char rep;
            do
            {
                Console.Clear();
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
                Console.Write("\n\nA and B (0)\nA or B (1)\nA not B (2)\nA + B(3)" + "\n\nEscolha a operação: ");
                while (!int.TryParse(Console.ReadLine(), out operacao) && (operacao < 0 || operacao > 3)) ;

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
