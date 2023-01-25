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

            do
            {
                Console.Write($"{jogador1.Nome} é a sua vez: ");
                string jogada1 = Console.ReadLine();
                if (jogada1 == "7")
                {
                    matriz[0, 0] = "X";
                    tabuleiro.ExibirTabuleiro(matriz);

                }

            } while (true);








        }





    }
}
