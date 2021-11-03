using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace User
{
    public class User
    {
        private string name;
        private string password;
        private DateTime date_naissance;

        public string Name {
            get => name;
            set { name = value; }  
        }

        public string Password {
            get {
                byte[] bytes = Encoding.Unicode.GetBytes(password);
                byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
                return Convert.ToBase64String(inArray);
            }
            set { password = value; }  
        }

        public DateTime Date_naissance
        {
            get => date_naissance;
            set {
                DateTime oDate = Convert.ToDateTime(value);
                date_naissance = oDate;
            }
        }
        public int getAge()
        {
            var today = DateTime.Today;

            int age = today.Year - date_naissance.Year;

            if (date_naissance.Date > today.AddYears(-age)) 
                age--;

            return age;
        }

    }
}
