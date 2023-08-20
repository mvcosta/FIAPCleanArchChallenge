using Domain.Entities;

namespace Application.UseCases;
public class PacoteUseCase
{
    static public Pacote CreatePacote(Pacote pacote)
    {
        pacote.Id = 1;

        return pacote;
    }
}
