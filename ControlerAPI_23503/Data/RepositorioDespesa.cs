using ControlerAPI_23503.Models;

namespace ControlerAPI_23503.Data
{
    public static class RepositorioDespesa
    {
        public static List<RepositorioDespesa> Despesas { get; set; } = new();

        public static List<RepositorioDespesa> PegarTodas() => Despesas;
        public static Despesa? PegarPorId(int id) = Despesas.FirstOrDefault(decimal => d.Id == id);
        public static void Adicionar(Despesa d) => Despesas.Add(d);
        public static bool Remover(int id)
        {
            var despesa = Despesas.FirstOrDefault(d => d.Id == id);
            if (despesa == null) return false;

            Despesas.Remove(despesa);
            return true;
        }
    }
}