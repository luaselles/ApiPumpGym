
using AutoMapper;
using Pump.Apllication.Commands;
using Pump.Domain.Entity;

namespace Pump.Apllication.Profiles
{
    public class ElementoProfile : Profile
    {
        public ElementoProfile()
        {

            CreateMap<CadastrarElementoPumpCommand, ElementoPumpEntity>()
                .ConstructUsing(m => new ElementoPumpEntity(m.Nome, m.Valor, m.Gramas));
           
            CreateMap<AtualizarElementoPumpCommand, ElementoPumpEntity>()
                .ConstructUsing(m => new ElementoPumpEntity(m.Nome, m.Valor, m.Gramas));

                

            // CreateMap<AtualizarElementoPumpViewModel,ElementoPumpEntity>()
            //     .ConstructUsing(m => new ElementoPumpEntity(m.Nome, m.Valor, m.Gramas));

            // CreateMap<ElementoPumpEntity, ElementoDetalheViewModel>()
            //     .ForMember(dest => dest.IdElementoPump, opt => opt.MapFrom(src => src.Id))
            //     .ForMember(dest => dest.NomeElementoPump, opt => opt.MapFrom(src => src.Nome))
            //     .ForMember(dest => dest.ValorElementoPump, opt => opt.MapFrom(src => src.Valor))
            //     .ForMember(dest => dest.GramasElementoPump, opt => opt.MapFrom(src => src.Gramas));
        }
    }
}