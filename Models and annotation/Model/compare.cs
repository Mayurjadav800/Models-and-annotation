using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models_and_annotation.Model
{
    public class compare
    {
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string Password { get; set; }



        //This is For the Foreignkey in data annotations
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
