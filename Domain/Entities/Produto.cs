namespace Domain.Entities;
public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public string Unidade { get; set; } = "und";
}
