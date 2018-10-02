using System;

namespace StatlerWaldorf.TeamService.Models
{
    public class Member
    {
        public Guid ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; } 

        public Member()
        {

        }
        public Member(Guid id):this()
        {
            this.ID = id;
        }
        public Member(String FirstName, String LastName,  Guid id):this(id)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public override String ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}