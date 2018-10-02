using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatlerWaldorf.TeamService.Models
{
    public class Team
    {
        public String Name { get; set; }
        public Guid ID { get; set; }
        public ICollection<Member> Members { get; set; }

        //Base Constructor
        public Team()
        {
            this.Members = new List<Member>();
        }
        //Constructor with name
        public Team(String name):this()
        {
            this.Name = name;
        }
        //Constructor with name and Id
        public Team(String name, Guid id):this(name)
        {
            this.ID = ID;
        }

        //Return the Teams name
        public override string ToString()
        {
            return this.Name;
        }
    }
}
