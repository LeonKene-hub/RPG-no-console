using RPG_no_console.Combate;

Heroi teste = new Heroi();

Console.WriteLine($"{teste.DanoAtaque()}");
teste.ReceberDano(31);
teste.ExibirVida();