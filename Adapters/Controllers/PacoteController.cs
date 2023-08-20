using Adapters.DTOs;
using Adapters.Gateways;
using Adapters.Interfaces;
using Application.UseCases;
using AutoMapper;
using Domain.Entities;

namespace Adapters.Controllers
{
    public class PacoteController : IPacoteController
    {
        private readonly IMapper _mapper;
        public PacoteController()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfiles>());
            _mapper = config.CreateMapper();
        }
        public PacoteResponse CreatePacote(PacoteRequest pacoteReq, IDataContext dataContext)
        {
            var pacote = _mapper.Map<Pacote>(pacoteReq);
            var pacoteGateway = new PacoteGateway(dataContext);
            var estoqueGateway = new EstoqueGateway(dataContext);

            pacote = PacoteUseCase.CreatePacote(pacote, pacoteGateway, estoqueGateway);

            return _mapper.Map<PacoteResponse>(pacote);
        }
    }
}