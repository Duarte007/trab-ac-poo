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
        }
    }
}
