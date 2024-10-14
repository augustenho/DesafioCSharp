Podcast Microwave = new Podcast("Apredendo C#", "Professor Dantas");
Episodio ep1 = new Episodio(1, "Introducao", 65);
Episodio ep2 = new Episodio(2, "Primeiros Passos", 105);

ep1.AdicionarConvidados("Thamiris Marcos");
ep1.AdicionarConvidados("Michel Teló");
Console.WriteLine(ep1.Resumo);
Microwave.AdicionarEpisodio(ep1);
Console.WriteLine(ep2.Resumo);
Microwave.AdicionarEpisodio(ep2);




Microwave.ExibirEpisodios();


