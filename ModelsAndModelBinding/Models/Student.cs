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
        [Required(ErrorMessage ="Please enter your full name.")]
        public string FullName { get; set; }

        /// <summary>
        /// The student's date of birth.
        /// </summary>
        [Display(Name = "Date of Birth: ")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Please enter a valid Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The student's email address.
        /// </summary>
        [Display(Name = "Email Address: ")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Required(ErrorMessage ="Please enter a valid Email Address (Ex: John.Doe@yahoo.com)")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The student's phone number!
        /// </summary>
        [Display(Name = "Phone Number: ")]
        [Required(ErrorMessage ="Please enter a valid phone number (Ex.: 123-245-6789)")]
        public string PhoneNumber { get; set; }
    }
}
