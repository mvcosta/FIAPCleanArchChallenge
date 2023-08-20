using AutoMapper;

using Adapters.DTOs;
using Domain.Entities;

namespace Adapters
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