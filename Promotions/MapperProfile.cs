using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promotion.API.Mappings
{
    public static class MapperProfile
    {
        public static IMapper AddMappings()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Promotion.Models.Document, Propmotions.Core.Document>()              
                .ReverseMap().ForMember(x => x.InstanceDetails, opt => opt.Ignore())
                .PreserveReferences();        

                cfg.CreateMap<Promotion.Models.Keyword, Propmotions.Core.Keyword>()               
                .ReverseMap().ForMember(x => x.InstanceDetails, opt => opt.Ignore());

                cfg.CreateMap<Promotion.Models.KeywordDocumentMapping, Propmotions.Core.KeywordDocumentMapping>()             
                .ReverseMap().ForMember(x => x.InstanceDetails, opt => opt.Ignore());

            });

            config.AssertConfigurationIsValid();

            return config.CreateMapper();
        }
    }
}
