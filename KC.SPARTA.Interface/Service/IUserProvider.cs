using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC.SPARTA.Interface.Service
{
   public interface IUserProvider
    {
        bool Validate(string Name, string Password);
        IAppUser GetUserContext(string UserId);
    }
}
