using Adapters.Interfaces;
using Application.Interfaces;
using Domain.Entities;

namespace Adapters.Gateways
{

    public class EstoqueGateway : IEstoqueGateway
    {
        private readonly IDataContext _dataContext;

        public EstoqueGateway(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public int AddProduto(Produto produto)
        {
            var existingProduct = _dataContext.EstoqueProdutos.FirstOrDefault(ep => ep.Produto == produto.Nome);

            if (existingProduct != null)
            {
                existingProduct.Quantidade += produto.Quantidade;
            }
            else
            {
                _dataContext.EstoqueProdutos.Add(new Estoque
                {
                    Produto = produto.Nome,
                    Quantidade = produto.Quantidade,
                    Unidade = produto.Unidade
                });
            }

            return _dataContext.SaveChanges();
        }
    }
}