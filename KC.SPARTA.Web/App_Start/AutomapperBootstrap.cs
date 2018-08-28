using AutoMapper;
using KC.SPARTA.Model.Model;
using KC.SPARTA.DataAccess;
using System.Collections.Generic;
using System.Collections;

namespace KC.SPARTA.Web
{
   
    public class AutomapperBootstrap : Profile
    {
        public AutomapperBootstrap()
        {
            //Map Source & Destination

            //CreateMap<GetLogs_Result, SampleModel>().ForMember(s => s.Id, m => m.MapFrom(u => u.Timestamp.ToString()));
            CreateMap<Log, SampleModel>();


        }
    }
}