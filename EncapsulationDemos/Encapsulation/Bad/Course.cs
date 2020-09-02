using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationDemos.Encapsulation.Bad
{
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
        public bool IsActive { get; set; }
        public int NumberOfStudents { get; set; }

    }
}
