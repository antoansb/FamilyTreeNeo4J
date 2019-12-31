using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokusaj1neo4j.DomainModel
{
    public class familyMember
    {
        public String id { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String birthday { get; set; }
        public String birthPlace { get; set; }
        public String yearOfDeath { get; set; }
        public String eAddress { get; set; }
        public String gender { get; set; }
        public String live { get; set; }
        public String biography { get; set; }
    }
}
