namespace Algoritmos
{
    internal static class PesquisaEmLargura
    {
        public static void PesquisarOPamonheiro()
        {
            var grafo = new Dictionary<string, string[]>
            {
                { "eu", new[] { "alice", "bob", "claire" } },
                { "bob", new[] { "anuj", "peggy" } },
                { "alice", new[] { "peggy" } },
                { "claire", new[] { "thom", "jonny" } },
                { "anuj", Array.Empty<string>() },
                { "peggy", Array.Empty<string>() },
                { "thom", Array.Empty<string>() },
                { "jonny", Array.Empty<string>() }
            };

            var pontoDePartida = grafo["eu"];
            var filaDePesquisa = new Queue<string>(pontoDePartida);
            var listaDePessoasPesquisadas = new List<string>();

            while (filaDePesquisa.Any())
            {
                var pessoa = filaDePesquisa.Dequeue();

                if (!listaDePessoasPesquisadas.Contains(pessoa))
                {
                    Console.WriteLine($"Investigando {pessoa}...");
                    if (PessoaEhPamonheira(pessoa))
                    {
                        Console.WriteLine($"{pessoa} é o(a) pamonheiro(a).");
                        return;
                    }
                    else
                    {
                        filaDePesquisa = new Queue<string>(filaDePesquisa.Concat(grafo[pessoa]));
                        listaDePessoasPesquisadas.Add(pessoa);
                    }
                }
            }
        }

        public static bool PessoaEhPamonheira(string nomePessoa)
        {
            return nomePessoa.StartsWith('t');
        }
    }
}

