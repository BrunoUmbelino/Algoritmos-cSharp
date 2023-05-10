using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class BuscaBinaria
    {
        public int ContadorDeTentativas { get; set; } = 0;
        public int? ImplementaBuscaBinaria(List<int> list, int itemBuscado)
        {
            var _list = list;
            var baixo = 0;
            var alto = _list.Count - 1;

            while(baixo <= alto)
            {
                ContadorDeTentativas++;

                var meio = (baixo + alto) / 2;
                var chute = Math.Floor((double)_list[meio]);
                Console.WriteLine("chute: " + chute);

                if (chute == itemBuscado)
                    return itemBuscado;
                if (chute > itemBuscado)
                    alto = meio - 1;
                if (chute < itemBuscado)
                    baixo = meio + 1;
            }

            return null;
        }

        public void UsaBuscaBinaria()
        {
            var lista = new List<int> { };
            for (var i = 1; i <= 100; i++)
            {
                lista.Add(i);
            }

            Console.WriteLine("Digite o número que deseja buscar da lista: ");
            var item = Convert.ToInt32(Console.ReadLine());

            var listaConcatenada = String.Join(",", lista);
            Console.WriteLine($"\nLista: [{listaConcatenada}]\n");

            var busca = new BuscaBinaria();
            var resultado = busca.ImplementaBuscaBinaria(lista, item);

            if (resultado == null)
            {
                Console.WriteLine($"\nNúmero {item} não encontrado.");
                return;
            }

            Console.WriteLine($"\nNúmero {resultado} encontrado com {busca.ContadorDeTentativas} tentativas.");
        }
    }
}
