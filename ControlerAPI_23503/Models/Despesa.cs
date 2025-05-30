namespace ControlerAPI_23503.Models
{
    public class Despesa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Fixa { get; set; }
    }
}