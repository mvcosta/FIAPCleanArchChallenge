using Adapters.Interfaces;
using Application.Interfaces;
using Domain.Entities;

namespace Adapters.Gateways
{
    public class PacoteGateway : IPacoteGateway
    {
        private readonly IDataContext _dataContext;

        public PacoteGateway(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public int Create(Pacote pacote)
        {
            _dataContext.Pacotes.Add(pacote);
            return _dataContext.SaveChanges();
        }
    }
}