using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokusaj1neo4j.DomainModel
{
   public class Family
    {
        public String familyName { get; set; }
        public List<familyMember> familyMembers { get; set; }
        public int numberOfMembers { get; set; }
    }
}
