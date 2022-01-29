using System.ComponentModel.DataAnnotations.Schema;

namespace UnitOfShop.Models
{
    public class Order
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Number { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}