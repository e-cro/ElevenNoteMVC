using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
   public class CategoryCreate
    {
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Maximum 20 characters")]
        [Display (Name = "Category Name")]
        public string CategoryName { get; set; }

        public override string ToString() => CategoryName;//what does this line do?
        
    }
}
