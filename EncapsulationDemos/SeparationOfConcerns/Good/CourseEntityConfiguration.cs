using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EncapsulationDemos.SeparationOfConcerns.Good
{
    public class CourseEntityConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(x => x.IsActive)
                .HasColumnName("Is_active");

            builder.Property(x => x.NumberOfStudents)
                .HasColumnName("Students_enrolled");
        }
    }
}
