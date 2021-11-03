using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User;

namespace TestDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            User.User u = new User.User();
            u.Name = "abdellah";
            u.Password = "boumaiza";
            u.Date_naissance = DateTime.Now;

            Console.WriteLine(u.getAge());
        }
    }
}
