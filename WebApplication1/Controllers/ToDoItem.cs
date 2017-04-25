using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Controllers
{
    public class ToDoItem
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string description { get; set; }
    }
}