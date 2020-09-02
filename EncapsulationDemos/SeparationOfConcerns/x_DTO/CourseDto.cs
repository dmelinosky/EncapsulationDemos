
namespace EncapsulationDemos.SeparationOfConcerns.x_DTO
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This is considered ok to do because:
    /// 1. DTO is just a simple container of data sent into the application.
    /// 2. Adding the input validation responsibility doesn't lead to exponential growth in complexity.
    /// </summary>
    public class CourseDto
    {
        [RegularExpression("[a-zA-Z]{1,50}")]
        public string Name { get; set; }
    }
}
