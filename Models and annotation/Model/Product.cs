using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models_and_annotation.Model
{
    public class PRoduct
    {
        [Key]
        //Its take default value hear 0
        [DefaultValue(0)]
        public int Id { get; set; }
        [MaxLength(100,ErrorMessage = "Maximum name is 100 word")]
        public string ProductName { get; set; }
    }
}
