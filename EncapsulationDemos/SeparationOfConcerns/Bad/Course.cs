using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EncapsulationDemos.SeparationOfConcerns.Bad
{

    /// <summary>
    /// This class violates the separation of concerns requirement.  It combines
    /// domain modeling of the Course class with ORM mapping.
    /// </summary>
    public class Course
    {
        [Column("Is_Active", TypeName = "char(1)")]
        public bool IsActive { get; set; }

        [Column("Students_enrolled", TypeName = "int")]
        public int NumberOfStudents { get; set; }
    }
}
