using System.ComponentModel.DataAnnotations;

namespace Models_and_annotation.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter customername")]
        [StringLength(100,ErrorMessage ="Custmorename will be not more than 100")]
        public string CustomerName { get; set; }
        [Range(1,100,ErrorMessage ="Number between the 1 to 100")]
        public decimal Total { get; set; }
    }
}
