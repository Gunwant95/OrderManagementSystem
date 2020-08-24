using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Class1
    {
        public string Name { get; set; }
        public string gender { get; set; }

        public static List<Class1> GetAllStud()
        {
            List<Class1> liststud = new List<Class1>();

            Class1 c1 = new Class1
            {
                Name = "Gunwant",
                gender = "Male"
            };
            liststud.Add(c1);

            Class1 c2 = new Class1
            {
                Name = "Amar",
                gender = "Male"
            };
            liststud.Add(c2);

            Class1 c3 = new Class1
            {
                Name = "Ankita",
                gender = "Female"
            };
            liststud.Add(c3);
            return liststud;
        }
    }
}