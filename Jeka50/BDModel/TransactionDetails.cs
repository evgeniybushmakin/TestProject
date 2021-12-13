using System;
using System.ComponentModel.DataAnnotations;

namespace Jeka50.BDModel
{
    public class TransactionDetails
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public int AcoountId { get; set; }
        
        [MaxLength(20, ErrorMessage="Max length username is 20 characters, please enter another name!")]
        public string UserName { get; set; }
        
        public DateTime? TransDateTime { get; set; }
        
        public DateTime? LastUpdateDateTime { get; set; }
        
        public string Brand { get; set; }
        
        public string Stack { get; set; }
        
        public string CustomerName { get; set; }
    }
}