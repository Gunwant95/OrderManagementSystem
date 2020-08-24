using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp_0608.Models
{
    public class ClassicMusic
    {
        public int ID { get; set; }
        public string title { get; set; }
        public DateTime releasedate { get; set; }
        public string Gener { get; set; }

        public string getDateTime()
        {
            return DateTime.Now.ToString();
        }
    }
}