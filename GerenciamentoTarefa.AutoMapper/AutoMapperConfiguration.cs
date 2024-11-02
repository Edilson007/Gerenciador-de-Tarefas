using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciamentoTarefas.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection RegisterMapping(this IServiceCollection services) 
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new EntityToDTOMapper());
                mc.AddProfile(new DTOToEntityMapper());
            });
           
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
