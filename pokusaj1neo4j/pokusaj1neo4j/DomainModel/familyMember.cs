using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokusaj1neo4j.DomainModel
{
    public class familyMember
    {
        public String name { get; set; }
        public String surname { get; set; }
        public String birthday { get; set; }
        public String city { get; set; }
        public String yearOfDeath { get; set; }
    }
}
