using System;
using POO_PortasLogicas;

namespace ULA {

    class UnidadeLogica {
        private int entradaA;
        private int entradaB;
        private int saidaD1;
        private int saidaD2;
        private int saidaD3;
        

        public UnidadeLogica(int entradaA, int entradaB, int saidaD1, int saidaD2, int saidaD3){
            this.entradaA = entradaA;
            this.entradaB = entradaB;
            this.saidaD1 = saidaD1;
            this.saidaD2 = saidaD2;
            this.saidaD3 = saidaD3;
        }

        public int getSaidaUL1(){
            return 0;
        }

        public int getSaidaUL2(){
            return 0;
        }

        public int getSaidaUL3(){
            return 0;
        }
    }
}
