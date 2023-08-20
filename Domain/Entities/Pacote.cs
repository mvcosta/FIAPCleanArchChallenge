namespace Domain.Entities;
public class Pacote
{
    public int Id { get; set; }
    public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
