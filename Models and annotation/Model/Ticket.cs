using MvcContrib.UI.InputBuilder.Attributes;

namespace Models_and_annotation.Model
{
    public class Ticket
    {
        [DisplayOrder(1)]
        public int Id { get; set; }
        [DisplayOrder(2)]
        public string Name { get; set; }
        //we can do more  hear
    }
}
