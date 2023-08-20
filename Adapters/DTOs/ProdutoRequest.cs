namespace Adapters.DTOs;
public class ProdutoRequest
{
    public string? Nome { get; set; }
    public int Quantidade { get; set; }
    public string Unidade { get; set; } = "und";
}
