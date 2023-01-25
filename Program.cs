using System;
using JogoDaVelha.Entities;
using JogoDaVelha.Services;

namespace JogoDaVelha;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("---------BEM VINDO AO JOGO DA VELHA--------");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("");

        Jogar novoJogo = new Jogar();
        novoJogo.IniciarJogo();
        
    }
}
