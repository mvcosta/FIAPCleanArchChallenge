using Adapters.DTOs;

namespace Adapters.Interfaces
{
    public interface IPacoteController
    {
        public PacoteResponse CreatePacote(PacoteRequest pacote, IDataContext dataContext);

    }
}