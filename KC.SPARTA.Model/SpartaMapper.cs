using AutoMapper;
using AutoMapper.Configuration;
using AutoMapper.Mappers;

namespace KC.SPARTA.Model
{
    public class SpartaMapper
    {

         public  IMapper _mapper;
        MapperConfiguration config;

        public SpartaMapper()
        {
            
            config = new MapperConfiguration(cfg => {
                cfg.CreateMap<NullableSourceMapper,NullableDestinationMapper>();
                

            });

            

            _mapper = config.CreateMapper();
            
            
        }

       

    }
}
