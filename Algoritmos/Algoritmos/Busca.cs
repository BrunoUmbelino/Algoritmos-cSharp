using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class Busca
    {
        public int ContadorDeTentativas { get; set; } = 0;
        public int? BuscaBinaria(List<int> list, int itemBuscado)
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
    }
}
