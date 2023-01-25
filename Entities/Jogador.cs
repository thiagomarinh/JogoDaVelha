namespace JogoDaVelha.Entities;

class Jogador
{
    public string Nome { get; set; }
    public int Pontuacao { get; set; } = 0;

    public Jogador() { }
    public Jogador(string nome)
    {
        Nome = nome;
        Pontuacao = 0;
    }

    public void SomarPontuacao(int pontuacao)
    {
        Pontuacao += pontuacao;
    }

    public void MostrarPontuacao()
    {
        Console.WriteLine(Pontuacao);
    }
}
