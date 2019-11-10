using System;
using POO_PortasLogicas;
using System.Collections.Generic;

namespace ULA {
    public class Ula8Bits {
        List<Ula> ulas1Bit = new List<Ula>();
        int[] saidas = new int[8];
        public Ula8Bits(int[] numA, int[] numB, int operacao){
            if(numA.Length == numB.Length && numA.Length == 8){
                for(int i = 0 ; i < 8 ; i++){
                    int carryIn = ulas1Bit.Contains(ulas1Bit[ulas1Bit.Count-1]) ? 
                                    ulas1Bit[ulas1Bit.Count-1].getCarryOut() : 0; 
                    ulas1Bit.Add(new Ula(numA[i], numB[i], operacao, carryIn));
                }
            }
        }

        public int[] getSaidas(){
            for(int i = 0 ; i < ulas1Bit.Count ; i++) {
                saidas[i] = ulas1Bit[i].getSaidaUla();
            }
            return saidas;
        }

    }
}
