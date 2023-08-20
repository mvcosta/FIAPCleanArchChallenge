namespace Adapters.DTOs;
public class PacoteRequest
{
    public ICollection<ProdutoRequest> Produtos { get; set; } = new List<ProdutoRequest>();
}
