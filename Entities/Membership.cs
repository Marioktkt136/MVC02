using System.ComponentModel.DataAnnotations.Schema;

namespace MVC02.Entities
{
    public class Membership : BaseEntity
    {
        public int MemberId { get; set; } 
        public Member Member { get; set; }

        public int PlanId { get; set; } 
        public Plan Plan { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Column Stutus[Not in DataBase]

        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "Upcoming"
                                : EndDate > DateTime.Now ? "Acive"
                                : "Expired";
    }
}
