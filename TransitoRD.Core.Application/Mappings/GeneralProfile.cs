using AutoMapper;
using TransitoRD.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitoRD.Core.Application.Dtos.Multas;
using TransitoRD.Core.Application.Dtos.Agentes;
using TransitoRD.Core.Application.Dtos.MultasTipo;
using TransitoRD.Core.Application.Dtos.Licencia;
using TransitoRD.Core.Application.Dtos.Vehiculo;


namespace TransitoRD.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region mapeo de Multas
            CreateMap<Multas, RequestMultasDto>()
                .ReverseMap()
                .ForMember(dest => dest.Creacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaio, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaionPor, opt => opt.Ignore());

            CreateMap<Multas, ResponseMultasDto>()
                ///.ForMember(dest => dest.Cantidad, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Creacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaio, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaionPor, opt => opt.Ignore());
            #endregion

            #region mapeo de Agentes
            CreateMap<Agentes, RequestAgentesDto>()
                .ReverseMap()
                .ForMember(dest => dest.Creacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaio, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaionPor, opt => opt.Ignore());

            CreateMap<Agentes, ResponseAgentesDto>()
                ///.ForMember(dest => dest.Cantidad, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Creacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaio, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaionPor, opt => opt.Ignore());
            #endregion

            #region mapeo de MultasTipo
            CreateMap<MultasTipo, RequestMultasTipoDto>()
                .ReverseMap()
                .ForMember(dest => dest.Creacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaio, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaionPor, opt => opt.Ignore());

            CreateMap<MultasTipo, ResponseMultasTipoDto>()
                ///.ForMember(dest => dest.Cantidad, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Creacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaio, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaionPor, opt => opt.Ignore());
            #endregion

            #region mapeo de Licencia
            CreateMap<Licencia, RequestlicenciaDto>()
                .ReverseMap()
                .ForMember(dest => dest.Creacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaio, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaionPor, opt => opt.Ignore());

            CreateMap<Licencia, ResponselicenciaDto>()
                ///.ForMember(dest => dest.Cantidad, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Creacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaio, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaionPor, opt => opt.Ignore());
            #endregion

            #region mapeo de Vehiculos
            CreateMap<Vehiculos, RequestVehiculoDto>()
                .ReverseMap()
                .ForMember(dest => dest.Creacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaio, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaionPor, opt => opt.Ignore());

            CreateMap<Vehiculos, ResponseVehiculoDto>()
                ///.ForMember(dest => dest.Cantidad, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Creacion, opt => opt.Ignore())
                .ForMember(dest => dest.CreadoPor, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaio, opt => opt.Ignore())
                .ForMember(dest => dest.UltimaModificaionPor, opt => opt.Ignore());
            #endregion

        }
    }
}
