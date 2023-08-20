using Adapters.AutoMapper;
using Adapters.DTOs;
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
        public PacoteResponse CreatePacote(PacoteRequest pacoteReq)
        {
            var pacote = _mapper.Map<Pacote>(pacoteReq);

            pacote = PacoteUseCase.CreatePacote(pacote);

            return _mapper.Map<PacoteResponse>(pacote);
        }
    }
}