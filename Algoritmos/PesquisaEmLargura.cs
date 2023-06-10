namespace Algoritmos
{
    internal static class PesquisaEmLargura
    {
        public static void PesquisarOPamonheiro()
        {
            var caderno = new Dictionary<string, string[]>();
            caderno.Add("eu", new string[] { "alice", "bob", "claire" });
            caderno.Add("bob", new string[] { "anuj", "peggy" });
            caderno.Add("alice", new string[] { "peggy" });
            caderno.Add("claire", new string[] { "thom", "jonny" });

            var pessoas = new List<string>() { };
            foreach (var pessoa in caderno)
            {
                pessoas.Add(pessoa.Key);
            }

            while (pessoas.Count > 0)
            {
                var pessoa = pessoas.FirstOrDefault();
                Console.WriteLine($"Investigando {pessoa}...");
                
                if (pessoa.StartsWith('t'))
                {
                    Console.WriteLine($"{pessoa} é o(a) pamonheiro(a).");
                    return;
                }
                else
                {
                    var contatos = caderno.GetValueOrDefault(pessoa);
                    if (contatos != null)
                    {
                        foreach (var contato in contatos)
                        {
                            if (!pessoas.Contains(contato)) pessoas.Add(contato);
                        }
                    }
                }
                pessoas.Remove(pessoa);
            }

            Console.WriteLine("Não existe pamonheiro.");
        }
    }
}

