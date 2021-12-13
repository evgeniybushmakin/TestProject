using System.ComponentModel.DataAnnotations;

namespace Jeka50.BDModel
{
    public class Transactions 
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        public string Value { get; set; }
        
        public string Type { get; set; }
        
        public string Name { get; set; }
    }
}