using RPG_no_console.Combate;

Heroi hero = new Heroi();
Inimigo ini = new Inimigo();

Inimigo a = ini.Gerar();

ini.ExibirVidaIni(a);
ini.ReceberDanoIni(a, hero.DanoAtaque());

ini.ExibirVidaIni(a);

Console.WriteLine($"==================");

hero.ExibirVida();
hero.ReceberDano(ini.DanoIni(a));
Console.WriteLine($"");

hero.ExibirVida();