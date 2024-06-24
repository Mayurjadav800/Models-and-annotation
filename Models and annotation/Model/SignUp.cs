using System.ComponentModel.DataAnnotations;

namespace Models_and_annotation.Model
{
    public class SignUp
    {
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [Compare("Password",ErrorMessage ="Password confirmation match the password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Password { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [Range(1,10)]
        public int age { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]*$")]
        public string UserName { get; set; }
        [CreditCard]
        public string CreditCardNumber { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
    }
}
