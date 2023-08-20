using Application.Interfaces;
using Domain.Entities;

namespace Application.UseCases;
public class PacoteUseCase
{
    static public Pacote CreatePacote(Pacote pacote, IPacoteGateway pacoteGateway, IEstoqueGateway estoqueGateway)
    {
        pacoteGateway.Create(pacote);
        foreach (var produto in pacote.Produtos)
        {
            estoqueGateway.AddProduto(produto);
        }
        return pacote;
    }
}
