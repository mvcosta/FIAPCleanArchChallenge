namespace Domain.Entities
{
    public class Estoque
    {
        public int? Id { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public string Unidade { get; set; } = "und";
    }
}