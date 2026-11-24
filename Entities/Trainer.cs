using MVC02.Entities.Enums;

namespace MVC02.Entities
{
    public class Trainer : GymUser
    {
        public Specialties Specialty { get; set; } = default!;
        public ICollection<Session> Sessions { get; set; } = default!;

    }
}
