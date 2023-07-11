namespace Algoritmos
{
    public class Djkstra
    {
        public void Buscar()
        {
            var grafo = new Dictionary<string, Dictionary<string, int>>(){
                {"inicio", new Dictionary<string, int>(){{"", 0}}},
                {"inicio", new Dictionary<string, int>(){{"a", 6}}},
                {"inicio", new Dictionary<string,int>(){{"b", 2}}},
                {"a", new Dictionary<string, int>(){{"", 0}}},
                {"a", new Dictionary<string, int>(){{"fim", 1}}},
                {"b", new Dictionary<string, int>(){{"", 0}}},
                {"b", new Dictionary<string, int>(){{"a", 3}}},
                {"b", new Dictionary<string, int>(){{"fim", 5}}},
                {"fim", new Dictionary<string, int>(){{"", int.MaxValue}}}
            };

            var custos = new Dictionary<string, int>(){
                {"a", 6},
                {"b", 2},
                {"fim", int.MaxValue}
            };

            var verticePai = new Dictionary<string, string>(){
                {"a", "inicio"},
                {"b", "inicio"},
                {"fim", "Sem pai"}
            };
        }
    }
}