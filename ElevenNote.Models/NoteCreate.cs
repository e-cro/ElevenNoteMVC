using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2, ErrorMessage ="Minimum length is 2 characters")]
        [MaxLength(100, ErrorMessage ="Maximum length is 100 characters")]
        public string Title { get; set; }
        [Required]
        [MinLength(1, ErrorMessage ="Must contain at least 1 character")]
        [MaxLength(8000, ErrorMessage ="Maximum length is 8,000 characters")]
        public string Content { get; set; }

        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name ="Category Name")]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
