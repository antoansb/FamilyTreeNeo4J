using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokusaj1neo4j.DomainModel
{
    public class User
    {
        public String login { get; set; }
        public String name { get; set; }
        public String password { get; set; }
        public List<User> relatives { get; set; }

        public void beRelatives(User user)
        {

        }
    }
}
