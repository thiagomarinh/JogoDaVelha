using JogoDaVelha.Entities;

namespace JogoDaVelha.Services
{
    class Jogar
    {
        public bool Ganhou = false;
        public Jogador Jogador;

        //inicialização matriz logo na criação
        string[,] matriz = { { "7", "8", "9" }, { "4", "5", "6" }, {"1","2","3"} };

        //instanciando um obj do tipo Tabuleiro
        Tabuleiro tabuleiro = new Tabuleiro();
        public void IniciarJogo()
        {
            tabuleiro.ExibirTabuleiro(matriz);

            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();

            Console.Write("Qual o nome do jogador referente ao X: ");
            jogador1.Nome = Console.ReadLine();
            Console.Write("Qual o nome do jogador referente ao O: ");
            jogador2.Nome = Console.ReadLine();
            Console.Clear();

            tabuleiro.ExibirTabuleiro(matriz);

            do
            {  
                Console.Write($"{jogador1.Nome} é a sua vez: ");
                string jogada1 = Console.ReadLine();
                
                for (int linha = 0; linha < 3; linha++)
                {
                    for (int coluna = 0; coluna < 3; coluna++)
                    {
                        if (matriz[linha,coluna] == jogada1 )
                        {
                            matriz[linha, coluna] = "X";
                            Console.Clear();
                            tabuleiro.ExibirTabuleiro(matriz);
                            
                        }
                        else if (matriz[linha, coluna] == "X" || matriz[linha, coluna] == "O")
                        {
                            Console.WriteLine("Voce nao pode jogar nessa posição");
                            break;
                        }

                    }
                    
                }

            
                
                Console.Write($"{jogador2.Nome} é a sua vez: ");
                string jogada2 = Console.ReadLine();

                for (int linha = 0; linha < 3; linha++)
                {
                    for (int coluna = 0; coluna < 3; coluna++)
                    {
                        if (matriz[linha, coluna] == jogada2)
                        {
                            matriz[linha, coluna] = "O";
                            Console.Clear();
                            tabuleiro.ExibirTabuleiro(matriz);

                        }
                    }

                }


            } while (true);








        }





    }
}
