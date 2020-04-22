using AutoMapper;


namespace BLL.Mapper
{
    class AutoMapperConfiguration
    {
        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ClientMappingProfile>();
               
                
            });
            return config;
        }
    }
}
