using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApp.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Application Type Name")]
        [Required]
        public string Name { get; set; }
        
    }
}
