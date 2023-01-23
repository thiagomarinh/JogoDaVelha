
namespace JogoDaVelha
{
    class Tabuleiro
    {
        public Jogador Jogador { get; set; }

        string[,] tabuleiro = new string[3, 3];
        public Tabuleiro()
        {
            
            tabuleiro[0, 0] = "7"; tabuleiro[0, 1] = "8"; tabuleiro[0, 2] = "9";
            tabuleiro[1, 0] = "4"; tabuleiro[1, 1] = "5"; tabuleiro[1, 2] = "6";
            tabuleiro[2, 0] = "1"; tabuleiro[2, 1] = "2"; tabuleiro[2, 2] = "3";
        }

        public void IniciarTabuleiro()
        {
            for (int linha = 0; linha < 3; linha++)
            {
                Console.Write("|");
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"{tabuleiro[linha, coluna]}|");
                }
                Console.WriteLine("");
            }
        }

        public void IniciarJogo()
        {
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();
            Console.Write("Digite o nome do jogador X: ");
            jogador1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o nome do jogador O: ");
            jogador2.Nome = Console.ReadLine();

            IniciarTabuleiro();

            do
            {
                
                

            } while (true);

        }
        




    }
}
