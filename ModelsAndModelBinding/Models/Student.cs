using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// Represents an individual student.
    /// </summary>
    public class Student
    {
        public int StudentId { get; set; }
        /// <summary>
        /// A student's first and last name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The student's date of birth.
        /// </summary>

        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The student's email address.
        /// </summary>

        public string EmailAddress { get; set; }

        /// <summary>
        /// The student's phone number!
        /// </summary>

        public string PhoneNumber { get; set; }
    }
}
