using AutoMapper;
using ComexApiT1.Dtos;
using ComexApiT1.Models;

namespace ComexApiT1.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDto, Cliente>();
            CreateMap<UpdateClienteDto, Cliente>();
            CreateMap<Cliente, ReadClienteDto>()
                .ForMember(clienteDto => clienteDto.Endereco,
                    opt => opt.MapFrom(cliente => cliente.Endereco));
        }
    }
}
