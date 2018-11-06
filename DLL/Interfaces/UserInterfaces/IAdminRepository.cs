using Entity.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaces.UserInterfaces
{
    public interface IAdminRepository : IUserRepository<Admin>
    {
        bool Delete(string id);
    }
}
