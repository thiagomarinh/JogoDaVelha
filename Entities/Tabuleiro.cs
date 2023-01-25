namespace JogoDaVelha.Entities
{
    class Tabuleiro
    {
        //metodo receber uma matriz como parametro
        public void ExibirTabuleiro(string[,] tabuleiro) 
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



    }
}
