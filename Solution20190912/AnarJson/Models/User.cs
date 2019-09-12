using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnarJson.Models
{
      

    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public int AddressId { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }

        public int CompanyId { get; set; }
        public Company company { get; set; }

        public List<Todo> Todos { get; set; }
        public List<Post> Posts { get; set; }
    }
}
