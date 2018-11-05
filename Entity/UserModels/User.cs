using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.UserModels
{
    public enum Role { Admin = 1, Executive = 2, Customer = 3 }
    //public enum Gender { Male = 1, Female = 2, None = 3 }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int NID { get; set; }
        public Role Role { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime UserSince { get; set; }


        //public DateTime? LastLogin { get; set; }
        public DateTime LastLogin { get; set; }

        public virtual User Copy(User user)
        {
            throw new NotImplementedException();
        }

        public string Type { get; set; }

        [NotMapped]
        public string LastActive { get; set; }// include day/month
        [NotMapped]
        public string MemberSince { get; set; }// include min/hrs/day



        public void TimeSpanUpdate()
        {

            TimeSpan activitySpan = DateTime.Now.Subtract(LastLogin);
            TimeSpan memberSpan = DateTime.Now.Subtract(UserSince);


            MemberSince = $"{memberSpan:%d} days";
            LastActive = $"{activitySpan:%h} hours {activitySpan:%m} minutes";


        }
    }
}
