using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;



namespace tabuleiro
{
    abstract internal class Peca
    {
        public Posicao posicao {  get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca (Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.tab = tab;
        }

        public Peca(Tabuleiro tab, Cor cor) // Depois verificar 
        {
            this.tab = tab;
            this.cor = cor;
        }
        public void incrementarQteMovimentos() 
        {
            qteMovimentos++;
        }

        public bool existeMovimentosPossiveis() // verificar se existe algum valor verdadeiro, se nao esta bloqueado
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis(); // Verificar para onde a peça pode mover
        
    }
}
