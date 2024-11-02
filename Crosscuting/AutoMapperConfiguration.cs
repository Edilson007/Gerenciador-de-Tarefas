using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarefas.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static void RegisterMapping(this IServiceCollection services) 
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new EntityToDTOMapper());
                mc.AddProfile(new DTOToEntityMapper());
            });
           
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
