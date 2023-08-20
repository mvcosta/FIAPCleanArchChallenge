using Domain.Entities;

namespace Application.Interfaces
{
    public interface IEstoqueGateway
    {
        public int AddProduto(Produto produto);

    }
}