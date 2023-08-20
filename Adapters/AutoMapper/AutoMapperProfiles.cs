using Adapters.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Adapters.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<PacoteRequest, Pacote>();
            CreateMap<Pacote, PacoteResponse>();
            CreateMap<ProdutoRequest, Produto>();
            CreateMap<Produto, ProdutoResponse>();
        }
    }
}