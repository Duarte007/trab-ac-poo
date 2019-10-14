using System;
using POO_PortasLogicas;

namespace ULA {
    class SomadorCompleto {
        private int entradaA;
        private int entradaB;
        private int saidaD4;
        private int carryIn;
        private int carryOut;

        public SomadorCompleto(int entradaA, int entradaB, int saidaD4, int carryIn){
            this.entradaA = entradaA;
            this.entradaB = entradaB;
            this.saidaD4 = saidaD4;
            this.carryIn = carryIn;
        }

        public void resolveCircuito(){
            //TODO
            POO_PortasLogicas.And2 and1 = new POO_PortasLogicas.And2();
            // POO_PortasLogicas.And2 and2 = new POO_PortasLogicas.And2();
            // POO_PortasLogicas.And2 and3 = new POO_PortasLogicas.And2();
            POO_PortasLogicas.Xor2 xor1 = new POO_PortasLogicas.Xor2();
            POO_PortasLogicas.Xor2 xor2 = new POO_PortasLogicas.Xor2();
            POO_PortasLogicas.Or2 or = new POO_PortasLogicas.Or2();

            xor1.setBit1(entradaB);
            xor1.setBit1(entradaA);


        }

        public int getSaidaSC(){
            return 0;
        }

        public int getCarryOut(){
            return 0;
        }
    }
}
