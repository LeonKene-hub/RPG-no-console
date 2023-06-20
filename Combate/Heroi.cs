using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_no_console.Combate
{
    public class Heroi
    {
        public string ? Nome;
        public static int Vida = 40;
        public static int Ataque;
        public static int Defesa;
        public static int Energia = 40;

        public int DanoAtaque()
        {
            Random rndAtk = new Random();
            int dice = rndAtk.Next(1, 21);

            Ataque = 3;
            int dano = 0;

            if (dice <= 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write($"Vc errou! ");
                Console.ResetColor();
                return dano;
            }
            else if (dice >= 5 && dice <= 10)
            {
                dano = Ataque;
                Console.Write($"Dano ");
                return dano;
            }
            else if (dice >= 11 && dice <= 17)
            {
                dano = ((int)(Ataque * 1.5));
                Console.Write($"Dano! ");
                return dano;
            }
            else if (dice >= 18 && dice <= 20)
            {
                dano = ((int)(Ataque * 2.2));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"DANO CRITICO! ");
                Console.ResetColor();
                return dano;
            }
            else
            {
                Console.Write($"Dano leve.. ");
                return dano + Ataque;
            }
        }

        public void ExibirVida()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"Vida:    ");
            Console.ResetColor();
            for (int i = 0; i < Vida; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"▓");
                Console.ResetColor();
            }
            
            Console.WriteLine($"");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"Energia: ");
            Console.ResetColor();
            for (int i = 0; i < Energia; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($"▓");
                Console.ResetColor();
            }

        }

        public void ReceberDano(int danoInimigo)
        {
            Vida -= danoInimigo;
        }

        public void Defender()
        {

        }

        public void Especial()
        {

        }
    }

}