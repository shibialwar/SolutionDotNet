using KC.SPARTA.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC.SPARTA.Interface.Business
{
    public interface IBusinessSample
    {
        IEnumerable<SampleModel> GetBizData();
    }
}
