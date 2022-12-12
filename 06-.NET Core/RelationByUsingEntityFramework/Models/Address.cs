

using System.ComponentModel.DataAnnotations;

namespace RelationByUsingEntityFramework.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Country { get; set; }

       
    }
}
