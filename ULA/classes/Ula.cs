using System;
using POO_PortasLogicas;

namespace ULA {
    class Ula {
        private int carryOut;
        private UnidadeLogica unidadeLogica;
        private Decodificador decodificador;
        private SomadorCompleto somadorCompleto;
        private int saidaUL1;
        private int saidaUL2;
        private int saidaUL3;
        private int saidaSC;
        private int saidaD1;
        private int saidaD2;
        private int saidaD3;
        private int saidaD4;

        public Ula(int entradaA, int entradaB, int operacao, int carryIn){
            this.decodificador = new Decodificador(operacao);
            this.saidaD1 = this.decodificador.getSaidaDecod1();
            this.saidaD2 = this.decodificador.getSaidaDecod2();
            this.saidaD3 = this.decodificador.getSaidaDecod3();
            this.saidaD4 = this.decodificador.getSaidaDecod4();
            this.unidadeLogica = new UnidadeLogica(entradaA, entradaB, saidaD1, saidaD2, saidaD3);
            this.saidaUL1 = unidadeLogica.getSaidaUL1();
            this.saidaUL2 = unidadeLogica.getSaidaUL2();
            this.saidaUL3 = unidadeLogica.getSaidaUL3();
            this.somadorCompleto = new SomadorCompleto(entradaA, entradaB, saidaD4, carryIn);
            this.saidaSC = somadorCompleto.getSaidaSC();
        }

        public int getResult(){
            POO_PortasLogicas.Or2 or = new POO_PortasLogicas.Or2();
            return 0;
        }



    }
}
