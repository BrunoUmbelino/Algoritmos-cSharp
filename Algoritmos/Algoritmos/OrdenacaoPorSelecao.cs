using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class InterfaceOrdenarPorSelecao
    {
        private OrdenacaoPorSelecao _ordenacao;

        public InterfaceOrdenarPorSelecao()
        {
            _ordenacao = new OrdenacaoPorSelecao();
        }

        public void AcionaOrdenacaoPorSelecao()
        {
            var listaParaOrdenar = new List<int>() { };
            var random = new Random();
            
            for (int i = 0; i < 10; i++) listaParaOrdenar.Add(random.Next(1, 101));
            Console.WriteLine($" Lista Desornedana: {String.Join(", ", listaParaOrdenar)}");

            var listaOrdenada = _ordenacao.OrdernaPorSelecao(listaParaOrdenar);
            Console.WriteLine($"\n Lista Ordenada: {String.Join(", ", listaOrdenada)}");
        }
    }

    public class OrdenacaoPorSelecao
    {
        public List<int> OrdernaPorSelecao(List<int> lista)
        {
            var arrayOrdenado = new List<int>() { };
            var lenght = lista.Count;

            for (var i = 0; i < lenght; i++)
            {
                var indiceDoMenor = BuscaIndiceDoMenor(lista);
                arrayOrdenado.Add(lista[indiceDoMenor]);
                lista.RemoveAt(indiceDoMenor);
            }

            return arrayOrdenado;
        }

        private int BuscaIndiceDoMenor(List<int> lista)
        {
            var menor = lista[0];
            var menorIndice = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] < menor)
                {
                    menor = lista[i];
                    menorIndice = i;
                }
            }

            return menorIndice;
        }
    }    
}
