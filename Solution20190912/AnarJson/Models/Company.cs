using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnarJson.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }

        public List<User> Users { get; set; }
    }
}
