using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_no_console.Combate
{
    public class Inimigo
    {
        public string? Nome;
        public int Vida;
        public int Ataque;
        public int Defesa;
        public List<Inimigo> ListaInimigos = new List<Inimigo>();

        public Inimigo Gerar()
        {
            Random rndIni = new Random();
            int dice = rndIni.Next(1, 21);

            Inimigo novo = new Inimigo();

            if (dice <= 3)
            {
                novo.Nome = "inimigo LVL1";
                novo.Vida = 10;
                novo.Ataque = 2;
                novo.Defesa = 2;
            }
            else if (dice <= 5)
            {
                novo.Nome = "inimigo LVL2";
                novo.Vida = 20;
                novo.Ataque = 4;
                novo.Defesa = 4;
            }
            else if (dice <= 10)
            {
                novo.Nome = "inimigo LVL3";
                novo.Vida = 30;
                novo.Ataque = 6;
                novo.Defesa = 6;
            }
            else if (dice <= 15)
            {
                novo.Nome = "inimigo LVL4";
                novo.Vida = 40;
                novo.Ataque = 8;
                novo.Defesa = 8;
            }
            else
            {
                novo.Nome = "inimigo LVL5";
                novo.Vida = 50;
                novo.Ataque = 10;
                novo.Defesa = 10;
            }

            ListaInimigos.Add(novo);
            return novo;
        }

        public void ExibirVidaIni(Inimigo inimigo)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Inimigo : ");
            for (int i = 0; i < inimigo.Vida; i++)
            {
                Console.Write($"▓");
            }
            Console.ResetColor();
            Console.WriteLine($"");
        }

        public int DanoIni(Inimigo inimigo)
        {
            return inimigo.Ataque;
        }
        public void ReceberDanoIni(Inimigo inimigo ,int danoHeroi)
        {
            float resistencia = (float)((Vida + Defesa) * 0.1);

            danoHeroi = (int)(danoHeroi - resistencia);

            inimigo.Vida -= danoHeroi;
        }
    }
}