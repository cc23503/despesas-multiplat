using ControlerAPI_23503.Models;

namespace ControlerAPI_23503.Data
{
    public static class RepositorioDespesa
    {
        private static List<Despesa> despesas = new();

        public static List<Despesa> PegarTodas()
        {
            return despesas;
        }

        public static void Adicionar(Despesa despesa)
        {
            despesas.Add(despesa);
        }

        public static Despesa PegarPorId(int id)
        {
            return despesas.FirstOrDefault(d => d.Id == id);
        }

        public static bool Remover(int id)
        {
            var despesa = PegarPorId(id);
            if (despesa != null)
            {
                despesas.Remove(despesa);
                return true;
            }
            return false;
        }
    }
}