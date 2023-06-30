using RPG_no_console.Combate;

Heroi teste = new Heroi();

Console.WriteLine($"{teste.DanoAtaque()}");
teste.ReceberDano(31);
teste.ExibirVida();

Console.WriteLine($"==================================");

teste.RecuperarVida(90);
teste.ExibirVida();
teste.Especial();

teste.ExibirStatus();