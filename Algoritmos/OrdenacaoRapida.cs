﻿namespace Algoritmos
{
    public class OrdenacaoRapida
    {
        public void InterfaceOrdenacaoRapida()
        {
            var arrAleatorio = new int[10];
            for (int i = 0; i < arrAleatorio.Length; i++)
            {
                arrAleatorio[i] = new Random().Next(1, 51);
            }

            Console.WriteLine("Lista Desordenada: " + String.Join(", ", arrAleatorio));
            var resultado = AcionaOrdenacaoRapida(arrAleatorio);
            Console.WriteLine("Lista Ordenada: " + String.Join(", ", resultado));
        }

        public IEnumerable<int> AcionaOrdenacaoRapida(IEnumerable<int> numeros)
        {
            if (numeros.Count() <= 1) return numeros;
            var pivo = numeros.First();
            var menores = numeros.Skip(1).Where(n => n <= pivo);
            var maiores = numeros.Skip(1).Where(n => n > pivo);

            var pivoToList = new List<int>() { pivo };
            return AcionaOrdenacaoRapida(menores)
                .Concat(pivoToList)
                .Concat(AcionaOrdenacaoRapida(maiores));
        }
    }
}
