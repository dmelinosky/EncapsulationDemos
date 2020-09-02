namespace EncapsulationDemos.Encapsulation.Good
{
    using Xunit;

    /// <summary>
    /// Business requirement (invariant):
    /// 1. an inactive course can not have any students in it.
    /// </summary>
    /// <remarks>
    /// This version of the class maintains encapsulation by reducing the
    /// public API surface area.  Reduced from two public methods that change
    /// the state of the object to one.
    /// </remarks>
    public class Course
    {
        public Course(bool active, int students)
        {
            this.IsActive = active;
            this.NumberOfStudents = students;
        }

        public bool IsActive { get; private set; }
        public int NumberOfStudents { get;  private set; }

        public void Disable()
        {
            IsActive = false;
            NumberOfStudents = 0;
        }

    }

    public class CourseTest
    {
        /// <summary>
        /// This test will pass because the only way to make a course inactive
        /// is to call Disable which ensures the business rule is met.
        /// </summary>
        [Fact]
        [Trait("Category", "Unit")]
        [Trait("Category", "Business Rule 1")]
        public void Inactive_course_has_no_students()
        {
            Course sut = new Course(true, 100);

            sut.Disable();

            Assert.Equal(0, sut.NumberOfStudents);
        }
    }
}
