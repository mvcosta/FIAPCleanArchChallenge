namespace Adapters.DTOs;
public class PacoteResponse
{
    public int Id { get; set; }
    public ICollection<ProdutoResponse> Produtos { get; set; } = new List<ProdutoResponse>();
}
