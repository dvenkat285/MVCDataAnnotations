using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Web.ModelBinding;


namespace MVCDataAnnotations.Models
{
    public class User
    {
        [Display(Name = "User Name:")]
        [Required(ErrorMessage ="User name field can't be empty.")]
        [RegularExpression(@"[A-Za-z\s]{3,}", ErrorMessage = "Name can have alphabets & spaces with min size of 3.")]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password field can't be left empty.")]
        [RegularExpression(@"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$_-])(?=\S+$).{8,16}", ErrorMessage = "Password Format: <br />-No spaces.<br />-Minimum 1 numeric.<br />-Minimum 1 upper case & lower case alphabet.<br />-Minimum 1, any of these Special characters: -, _, @, #, $.<br />-Should be ranging between 8 - 16 chars.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm password field can't be left empty.")]
        [Compare("Password", ErrorMessage = "Confirm password should match with password.")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of birth field can't be left empty.")]
        [System.Web.Mvc.Remote("IsValidDate", "User", ErrorMessage = "User should attain 18 years age to register.")]
        public DateTime DOB { get; set; }  //ajax code for server side validation client don't have send req but
                                                                    //   it will update automatic (remote with mvc namespace and  isvalidDate)

        [Display(Name = "Mobile No")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Mobile No. field can't be left empty.")]
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Mobile No. should start with 6, 7, 8, and 9 only and can be having a length of 10 digits(both Max & Min).")]
        public string Mobile { get; set; }

        [Display(Name = "Email Id")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "User Addresss")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }
}