
namespace tabuleiro {
    class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtmivimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca (Posicao posuicao,Tabuleiro tab, Cor cor {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qtmivimentos = 0;


        }
    }
}
