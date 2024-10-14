### Definindo Classes e Funçoes:
        
        class Podcast
        {
            private List<Episodio> episodios { get; }
            private string resumo { get; }
            public string Nome { get; }
            public string Host { get; }
            public int TotalEpisodios => episodios.Count;
        
            public Podcast(string host, string nome)
            {
                episodios = new List<Episodio>();
                Host = nome;
                Nome = host;
            }
        
            public void CriarEpisodio(int ordem, string titulo, int duracao)
            {
                Episodio episodio = new Episodio(ordem, titulo, duracao);
                episodios.Add(episodio);
                Console.WriteLine($"Episódio: {episodio.Titulo} -  foi adicionado ao {this.Nome} ");
        
            }
        
            public void AdicionarEpisodio(Episodio episodio)
            {
                episodios.Add(episodio);
                Console.WriteLine($"Episodio Adicionado ao {Nome}.");
                Thread.Sleep(2000);
            }
        
            public void ExibirEpisodios()
            {
                Console.Clear();
                Console.WriteLine($"Lista de Episódios do PodCast: {Nome} - By {Host}\n");
                foreach (var epo in episodios.OrderBy(e => e.Ordem))
                {
                    Console.WriteLine($"{epo.Ordem}º - {epo.Titulo} - {epo.Duracao} minutos");
                }
            }
        }
            class Episodio
            {
                private List<string> convidados { get; set; }
                public double Duracao { get; set; }
                public int Ordem { get; set; }
                public string Titulo { get; set; }
                public string Resumo => $"\n{Ordem} - {Titulo} - {Duracao} Minutos - Convidados: {string.Join(", ", convidados)}";
        
                public void AdicionarConvidados(string nome)
                {
                    convidados.Add(nome);
                    Console.WriteLine($"{nome} foi adicionado como Convidado ");
                    Thread.Sleep(1000);
        
                }
                public Episodio(int ordem, string titulo, int duracao)
                {
                    Ordem = ordem;
                    Titulo = titulo;
                    Duracao = duracao;
                    convidados = new List<string>();
                }
            }


  ### Atribuindo valores

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

### Output:

        Lista de Episódios do PodCast: Apredendo C# - By Professor Dantas
        
        1º - Introducao - 65 minutos
        2º - Primeiros Passos - 105 minutos


