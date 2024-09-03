using tabuleiro;

namespace xadrez
{
    internal class PosicaoXadrez
    {
        public char coluna {  get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) // constructor
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao () // método para converter posicao do xadrez para posicao na matriz
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString() // to string
        {
            return "" + coluna + linha;
        }
    }
}
