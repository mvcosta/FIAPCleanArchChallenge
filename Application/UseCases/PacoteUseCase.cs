using Application.Interfaces;
using Domain.Entities;

namespace Application.UseCases;
public class PacoteUseCase
{
    static public Pacote CreatePacote(Pacote pacote, IPacoteGateway pacoteGateway)
    {
        pacoteGateway.Create(pacote);
        return pacote;
    }
}
