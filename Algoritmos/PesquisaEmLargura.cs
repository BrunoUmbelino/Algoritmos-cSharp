﻿using System;
using System.Collections;

namespace Algoritmos
{
    internal static class PesquisaEmLargura
    {
        public static void PesquisarOPamonheiro()
        {
            var grafo = new Dictionary<string, string[]>();
            grafo.Add("eu", new string[] { "alice", "bob", "claire" });
            grafo.Add("bob", new string[] { "anuj", "peggy" });
            grafo.Add("alice", new string[] { "peggy" });
            grafo.Add("claire", new string[] { "thom", "jonny" });
            grafo.Add("anuj", Array.Empty<string>());
            grafo.Add("peggy", Array.Empty<string>());
            grafo.Add("thom", Array.Empty<string>());
            grafo.Add("jonny", Array.Empty<string>());

            //var pessoas = new List<string>() { };
            //foreach (var pessoa in grafo)
            //{
            //    pessoas.Add(pessoa.Key);
            //}

            //    while (pessoas.Count > 0)
            //    {
            //        var pessoa = pessoas.First();
            //        Console.WriteLine($"Investigando {pessoa}...");

            //        if (PessoaEhPamonheira(pessoa))
            //        {
            //            Console.WriteLine($"{pessoa} é o(a) pamonheiro(a).");
            //            return;
            //        }
            //        else
            //        {
            //            var contatos = grafo.GetValueOrDefault(pessoa);
            //            if (contatos != null)
            //            {
            //                foreach (var contato in contatos)
            //                {
            //                    if (!pessoas.Contains(contato)) 
            //                        pessoas.Add(contato);
            //                }
            //            }
            //        }
            //        pessoas.Remove(pessoa);
            //    }

            //    Console.WriteLine("Não existe pamonheiro.");
            //}

            var pontoDePartida = grafo["eu"];
            var filaDePesquisa = new Queue<string>(pontoDePartida);
            var listaDePessoasPesquisadas = new List<string>();

            while (filaDePesquisa.Any())
            {
                var pessoa = filaDePesquisa.Dequeue();
                Console.WriteLine($"Investigando {pessoa}...");

                if (!listaDePessoasPesquisadas.Contains(pessoa))
                {
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

