
namespace EncapsulationDemos.Encapsulation.Bad
{
    using Xunit;

    /// <summary>
    /// Business requirement (invariant):
    /// 1. an inactive course can not have any students in it.
    /// </summary>
    /// <remarks>
    /// No way to enforce the invariant because clients of this class
    /// can set the properties to anything they want.  Therefore the class
    /// is not encapsulated, it can be brought to an inconsistent state.
    /// </remarks>
    public class Course
    {
        public Course(bool active, int students)
        {
            this.IsActive = active;
            this.NumberOfStudents = students;
        }

        public bool IsActive { get; set; }
        public int NumberOfStudents { get; set; }

    }

    public class CourseTests
    {
        /// <summary>
        /// This test will fail because the developer has to remember to set the correct
        /// state of the object each time they change the IsActive flag and in this case 
        /// they did not.
        /// </summary>
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Category", "Business Rule 1")]
        public void Inactive_course_has_no_students()
        {
            Course sut = new Course(true, 100);

            sut.IsActive = false;

            Assert.Equal(0, sut.NumberOfStudents);
        }
    }
}
