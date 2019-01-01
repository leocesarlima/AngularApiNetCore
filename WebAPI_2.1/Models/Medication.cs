using System.ComponentModel.DataAnnotations;

namespace WebAPI_2._1.Models
{
    public class Medication
    {
        [Key]
        public string Name { get; set; }
        public string Doses { get; set; }
    }
}
