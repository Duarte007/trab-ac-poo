using System;
using POO_PortasLogicas;

namespace ULA {
    class Decodificador {
        private int f0;
        private int f1;

        public Decodificador(int operacao){
            switch(operacao){
                case 0: //and
                break;
                case 1: //or
                break;
                case 2: //not
                break;
                case 3: //soma
                break;
            }
        }

        public int getSaidaDecod1(){
            return 0;
        }

        public int getSaidaDecod2(){
            return 0;
        }

        public int getSaidaDecod3(){
            return 0;
        }

        public int getSaidaDecod4(){
            return 0;
        }

    }
}
