using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_no_console.Combate
{
    public class Heroi
    {
        public string ? Nome;
        public int Vida = 40;
        public static int VidaMaxima = 40;
        public static int Ataque = 5;
        public static int Defesa = 5;
        public static int Energia = 40;

        public int DanoAtaque()
        {
            Random rndAtk = new Random();
            int dice = rndAtk.Next(1, 21);

            int dano = 0;

            if (dice <= 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write($"Vc errou! {dano}");
                Console.ResetColor();
                Console.WriteLine($"");
                
                return dano;
            }
            else if (dice >= 5 && dice <= 10)
            {
                dano = Ataque;
                Console.Write($"Dano {dano}");
                Console.WriteLine($"");
                return dano;
            }
            else if (dice >= 11 && dice <= 17)
            {
                dano = ((int)(Ataque * 1.5));
                Console.Write($"Dano! {dano}");
                Console.WriteLine($"");
                return dano;
            }
            else if (dice >= 18 && dice <= 20)
            {
                dano = ((int)(Ataque * 2.2));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"DANO CRITICO! {dano}");
                Console.ResetColor();
                Console.WriteLine($"");
                return dano;
            }
            else
            {
                Console.Write($"Dano leve.. ");
                Console.WriteLine($"");
                return dano + Ataque;
            }
        }

        public void ExibirVida()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"PV: ");
            Console.ResetColor();
            for (int i = 0; i < Vida; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"▓");
                Console.ResetColor();
            }
            
            Console.WriteLine($"");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"PE: ");
            Console.ResetColor();
            for (int i = 0; i < Energia; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($"▓");
                Console.ResetColor();
            }

            Console.WriteLine($"");
        }

        public void ExibirStatus()
        {
            Console.WriteLine(@$"
    |==========|
    | Nome: {Nome}   |
    | PV: {Vida}   |
    | PE: {Energia}   |
    | PvMax: {VidaMaxima}|
    | ATK: {Ataque}   |
    | DEF: {Defesa}   |
    |==========|
            ");
            
        }

        public void ReceberDano(int danoInimigo)
        {
            float resistencia = (float)((Vida + Defesa) * 0.1);

            danoInimigo = (int)(danoInimigo - resistencia);

            Vida -= danoInimigo;
            Console.WriteLine($"Sofreu {danoInimigo}");
        }

        public void RecuperarVida(int recuperado)
        {
            Vida = Vida + recuperado;

            if (Vida > VidaMaxima)
            {
                Vida = VidaMaxima;
            }
        }
        public int Especial()
        {
            int danoEspecial = Ataque * 10;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"DANO SUPREMO {danoEspecial}!");
            Console.ResetColor();

            return danoEspecial;
        }
    }

}