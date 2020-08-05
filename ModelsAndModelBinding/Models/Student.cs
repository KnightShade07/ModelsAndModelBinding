using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Full Name: ")]
        public string FullName { get; set; }

        /// <summary>
        /// The student's date of birth.
        /// </summary>
        [Display(Name = "Date of Birth: ")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The student's email address.
        /// </summary>
        [Display(Name = "Email Address: ")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The student's phone number!
        /// </summary>
        [Display(Name = "Phone Number: ")]
        public string PhoneNumber { get; set; }
    }
}
