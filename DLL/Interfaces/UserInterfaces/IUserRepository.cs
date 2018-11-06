using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaces.UserInterfaces
{
    public interface IUserRepository<T>
    {
        T GetByEmail(string email);
        List<T> GetAll();
        bool Add(T entity);
        bool Update(T entity);
        bool UpdatePassword(string email, string password);
        bool Remove(string userName);
    }
}
