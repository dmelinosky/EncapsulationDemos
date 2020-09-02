namespace EncapsulationDemos.SeparationOfConcerns.Good
{

    /// <summary>
    /// This class is better, it only represents a model in the domain.
    /// </summary>
    public class Course
    {
        public bool IsActive { get; set; }
        public int NumberOfStudents { get; set; }
    }
}
