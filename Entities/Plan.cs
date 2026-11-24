namespace MVC02.Entities
{
    public class Plan : BaseEntity
    {
        public string Name { get; set; } = default!;
        public decimal Price{ get; set; }
        public string Decription { get; set; } = default!;
        public int DurationDays { get; set; }
        public bool IsActive { get; set; } = default!;
        public ICollection<Membership> PlanSubscription { get; set; } = default!;

    }
}
