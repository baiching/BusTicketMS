using Entity.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;


namespace DLL.UserContext
{
    public class UserRepository<T> where T : User
    {
        public bool Add(T t)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetByEmail(string email)
        {
            using (var context = new Context())
            {
                return context.Set<T>().FirstOrDefault(r => r.Email == email);
            }
        }

        public bool Remove(string userName)
        {
            throw new NotImplementedException();
        }

        public bool Update(T t)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePassword(string email, string password)
        {
            using (var context = new Context())
            {
                try
                {
                    var user = context.Set<T>().First(r => r.Email == email);
                    user.Password = password;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }

            }
        }
    }
}
