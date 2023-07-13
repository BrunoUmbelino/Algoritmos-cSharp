namespace Algoritmos
{
    public class Dijkstra
    {
        public static void Buscar()
        {
            var infinito = int.MaxValue;

            var grafo = new Dictionary<string, Dictionary<string, int>>(){
                {"inicio", new Dictionary<string, int>(){{"a", 6}, {"b",2}}},
                {"a", new Dictionary<string, int>(){{"fim", 1}}},
                {"b", new Dictionary<string, int>(){{"a", 3}, {"fim", 5}}},
                {"fim", new Dictionary<string, int>(){}}
            };

            var custos = new Dictionary<string, int>(){
                {"a", 6},
                {"b", 2},
                {"fim", infinito}
            };

            var verticesFilhoPai = new Dictionary<string, string>(){
                {"a", "inicio"},
                {"b", "inicio"},
                {"fim", "Sem pai"}
            };

            var verticesProcessados = new List<string>(){};

            var verticeEmProcesso = BuscaVerticeDeMenorCustoNãoProcessado(custos, verticesProcessados);
            while (verticeEmProcesso != String.Empty){
                var custoDoVerticeEmProcesso = custos[verticeEmProcesso];
                var vizinhosDoVerticeEmProcesso = grafo[verticeEmProcesso];

                foreach(var v in vizinhosDoVerticeEmProcesso.Keys){
                    var novoCusto = custoDoVerticeEmProcesso + vizinhosDoVerticeEmProcesso[v];
                    if (novoCusto < custos[v]){
                        custos[v] = novoCusto;
                        verticesFilhoPai[v] = verticeEmProcesso;
                    }
                }
                verticesProcessados.Add(verticeEmProcesso);
                verticeEmProcesso = BuscaVerticeDeMenorCustoNãoProcessado(custos, verticesProcessados);
            }

            var texto = "";
            foreach(var p in verticesFilhoPai){
                texto += $"Vertice : {p.Key} é  filho de {p.Value} \n"; 
            }
            System.Console.WriteLine(texto);
        }

        private static string BuscaVerticeDeMenorCustoNãoProcessado(Dictionary<string, int> custos, List<string> verticesProcessados)
        {
            var menorCusto = int.MaxValue;
            var verticeDeMenorCusto = string.Empty;

            foreach(var vertice in custos.Keys){
                var custo = custos[vertice];
                if (custo < menorCusto && !verticesProcessados.Contains(vertice)){
                    menorCusto = custo;
                    verticeDeMenorCusto = vertice;
                }
            }

            return verticeDeMenorCusto;
        }
    }
}