using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [Display(Name = "Date Created")]//Erick had this here, but I think could be added in specific Models instead?
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Date Modified")]//same as Date Created note
        public DateTimeOffset? ModifiedUtc { get; set; }

        //One to many relationship. One category can have many notes.

        //The below two lines set up the foreign key using Entity Framework
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }//can make this nullable in order to reference the new addition of CategoryId (since we already made the database without it) without deleting the database. Instead I am making it required but this means I have to delete database first and start over with populating the table (to delete database, delete it in the SQL Server Explorer)
        public virtual Category Category { get; set; }//this is the navigation property

        
    }
}
