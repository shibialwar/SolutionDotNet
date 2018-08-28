using KC.SPARTA.Model.Model;
using System.Collections.Generic;
using System.Linq;

namespace KC.SPARTA.DataAccess
{
    public class SampleDAL
    {
        AutoMapper.IMapper _mapper;
        DbConnection _connection;

        public SampleDAL(AutoMapper.IMapper MyMapper ,DbConnection Connection)
        {
            _mapper = MyMapper;
            _connection = Connection;
        }

        public IEnumerable<SampleModel> GetData(int id)
        {
            IEnumerable<Log> result;

            result = from rec in _connection.Db.Logs select rec;
                
            var rtn = _mapper.Map<IEnumerable<Log>, IEnumerable<SampleModel>>(result);


            return rtn;
        }
    }
}
