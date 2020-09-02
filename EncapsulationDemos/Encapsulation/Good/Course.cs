namespace EncapsulationDemos.Encapsulation.Good
{
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
        public bool IsActive { get; private set; }
        public int NumberOfStudents { get;  private set; }

        public void Disable()
        {
            IsActive = false;
            NumberOfStudents = 0;
        }

    }
}
