using System;

namespace ULA {
    class Program {
        static int numA = 0, numB = 0;

        static void getEntradaA(){
            do{
                try{
                    Console.Write("Insira um 0 ou 1 para A: ");
                    numA = int.Parse(Console.ReadLine()); 
                    if(numA != 0 && numA != 1){
                        Console.WriteLine("Valor invalido!");
                    }
                } catch (Exception error){
                    Console.WriteLine(error.Message);
                }
            } while (numA != 0 && numA != 1);
        }

        static void getEntradaB(){
            do{
                try{
                    Console.Write("Insira um 0 ou 1 para B: ");
                    numB = int.Parse(Console.ReadLine());
                    if(numB != 0 && numB != 1){
                        Console.WriteLine("Valor invalido!");
                    }
                } catch (Exception error){
                    Console.WriteLine(error.Message);
                }
            } while (numB != 0 && numB != 1);
        }

        static void Main(string[] args) {
         

            int operacao = -1;            
            char rep;
            do
            {
                do{
                    try{
                        Console.Clear();
                        Console.Write("\n\n(0) A and B\n(1) A or B\n(2) not B \n(3) A + B" + "\n\nEscolha a operação: ");
                        operacao = int.Parse(Console.ReadLine());
                        if(operacao < 0 || operacao > 4){
                            Console.WriteLine("Opcao invalida!");
                        }
                    } catch (Exception error){
                        operacao = -1;
                        Console.WriteLine(error.Message);
                    }
                } while (operacao < 0 || operacao > 4);

                switch(operacao){
                    case 0:
                    case 1:
                    case 3:
                        getEntradaA();
                        getEntradaB();
                    break;

                    case 2:
                        getEntradaB();
                    break;

                    default:
                        Console.WriteLine("Valor invalido");
                    break;
                }

                Console.Clear();
                Console.WriteLine("A: " + numA.ToString() + " | B: " + numB.ToString());

                Ula u = new Ula(numA, numB, operacao, 0);
                u.resolveCircuito();
                Console.WriteLine("O resultado é: " + u.getSaidaUla());

                do {
                    Console.Write("\n\nDeseja continuar? (s/n)");
                } while (char.TryParse(Console.ReadLine().ToLower(), out rep) && (!rep.Equals('s') && !rep.Equals('n')));

            } while (rep.Equals('s'));
                                          
        }
    }
}
