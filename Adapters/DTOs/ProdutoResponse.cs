namespace Adapters.DTOs;
public class ProdutoResponse
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public int Quantidade { get; set; }
    public string Unidade { get; set; } = "und";
}
