namespace Algoritmos
{
    static public class Recursividade
    {
        public static void ContagemRegressiva(int i)
        {
            Console.WriteLine(i);
            if (i <= 0) return;
            else ContagemRegressiva(i - 1);
        }

        public static int Fatorar(int x)
        {
            if (x == 1) return 1;
            else return x * (Fatorar(x - 1));
        }

        public static double Somar(IEnumerable<int> numeros)
        {
            if (!numeros.Any()) return 0;
            else return numeros.First() + Somar(numeros.Skip(1));
        }

        public static int Contar(IEnumerable<int> itens)
        {
            if (!itens.Any()) return 0;
            else return 1 + Contar(itens.Skip(1));
        }

        public static int BuscarMaior(IEnumerable<int> numeros)
        {
            if (numeros.Count() == 1) return numeros.First();
            else
            {
                var maior = numeros.First();
                if (maior > numeros.First())
                {
                    return maior;
                }
                else return BuscarMaior(numeros.Skip(1));
            }
        }
    }
}
