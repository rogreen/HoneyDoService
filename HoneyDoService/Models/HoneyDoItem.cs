using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoneyDoService.Models
{
    public class HoneyDoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        public string Description { get; set; }
        public string AssignedTo { get; set; }
        public string Priority { get; set; }
        public string Category { get; set; }
        public DateTime DueDate { get; set; }
        public string Recurrence { get; set; }
        public bool Completed { get; set; }
    }
}
