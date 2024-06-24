using System.ComponentModel.DataAnnotations;

namespace Models_and_annotation.Model
{
    public class Employee
    {
        [Display(Name ="Employee Id")]
        public string EmpId { get; set; }
        [Display(Name ="Date of joining")]
        public DateTime DOJ { get; set; }

        [Display(Name = "IsPeramenent")]
        public bool IsPeramenent { get; set; }
    }
}
