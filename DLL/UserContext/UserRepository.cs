using Entity.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity;
using DLL.Interfaces.UserInterfaces;

namespace DLL.UserContext
{
    public class UserRepository<T> : IUserRepository<T> where T : User
    {
        internal Context context = new Context();
        public virtual bool Add(T entity)
        {
            context.Set<T>().Add(entity);
            return context.SaveChanges() > 0;
        }

        public virtual List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public virtual T GetByEmail(string email)
        {
            
            return context.Set<T>().FirstOrDefault(r => r.Email == email);
            
        }

        public virtual bool Remove(string userName)
        {
            throw new NotImplementedException();
        }

        public virtual bool Update(T entity)
        {
            context.Entry<T>(entity).State = EntityState.Modified;
            return context.SaveChanges() > 0;
        }

        public virtual bool UpdatePassword(string email, string password)
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
