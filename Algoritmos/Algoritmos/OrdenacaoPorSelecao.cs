using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class OrdenacaoPorSelecao
    {

        private int BuscaIndiceDoMenor(List<int> lista)
        {
            var menor = lista[0];
            var menorIndice = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (i < menor) 
                { 
                    menor = lista[i]; 
                    menorIndice = i;
                }
            }

            return menorIndice;
        }

        public List<int> OrdernaPorSelecao(List<int> lista)
        {
            var novaLista = new List<int>();

            for(var i = 0; i < lista.Count; i++)
            {
                var indiceDoMenor = BuscaIndiceDoMenor(lista);
                novaLista.Add(indiceDoMenor);
                lista.RemoveAt(indiceDoMenor);
            }

            return novaLista;
        }

        public void InterfaceOrdenarPorSelecao()
        {
            var arrayAleatorio = new List<int>() { };
            var random = new Random();

            for (int i = 0; i < 10; i++)
                arrayAleatorio.Add(random.Next(1, 101));
            
            Console.WriteLine(String.Join(",", arrayAleatorio));

            var ordenacao = new OrdenacaoPorSelecao().OrdernaPorSelecao(arrayAleatorio);

            Console.WriteLine("\n\n" + String.Join(",", ordenacao));
        }
    }
}
