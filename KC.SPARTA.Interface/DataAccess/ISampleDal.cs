using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KC.SPARTA.Model.Model;

namespace KC.SPARTA.Interface.DataAccess
{
    public interface ISampleDal
    {
        IEnumerable<SampleModel> GetSampleData(int Id);
    }
}
