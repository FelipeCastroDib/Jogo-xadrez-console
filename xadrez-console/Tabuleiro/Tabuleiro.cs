using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.Tabuleiro
{
    internal class Tabuleiro
    {
        public int linha { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro ( int linhas, int colunas )
        {
            this.linha = linhas;
            this.colunas = colunas;
            pecas = new Peca[ linhas, colunas ];
        }
    }
}
