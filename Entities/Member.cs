namespace MVC02.Entities
{
    public class Member : GymUser
    {
        public string? Photo { get; set; } //Modifications
        public ICollection<Membership> MemberSubscription { get; set; } = default!;

    }
}
