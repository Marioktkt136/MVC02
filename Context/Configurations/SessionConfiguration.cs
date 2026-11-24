using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC02.Entities;

namespace MVC02.Context.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(X => X.CreatedAy)
                .HasDefaultValueSql("GETDATE()");

            builder.HasOne(x => x.Trainer)
                   .WithMany(x => x.Sessions)
                   .HasForeignKey(x => x.TrainerId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(T =>
            {
                T.HasCheckConstraint("SessionCapacityCheck", "Capacity between 1 And 25");
                T.HasCheckConstraint("SessionEndDateAfterStardDateCheck", "EndDate > StartDate");
            });
        }
    }
}
