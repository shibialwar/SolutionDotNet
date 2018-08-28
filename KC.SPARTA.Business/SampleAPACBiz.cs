using AutoMapper;
using System.Collections.Generic;
using KC.SPARTA.Interface.Business;
using KC.SPARTA.Model.Model;
using KC.SPARTA.DataAccess;


namespace KC.SPARTA.Business
{
    public class SampleAPACBiz : IBusinessSample
    {
        SampleDAL _dao;

        public SampleAPACBiz(IMapper MyMapper, DbConnection Connection)
        {
            _dao = new SampleDAL(MyMapper, Connection);
        }

        public IEnumerable<SampleModel> GetBizData()
        {
            return  _dao.GetData(1);
        }
    }
}
