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

        public int getSaidaSC(){
            return 0;
        }

        public int getCarryOut(){
            return 0;
        }
    }
}
