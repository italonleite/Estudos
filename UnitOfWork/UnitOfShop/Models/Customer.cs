using System.ComponentModel.DataAnnotations.Schema;

namespace UnitOfShop.Models
{
    public class Customer
    {

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string name { get; set; }

    }
}