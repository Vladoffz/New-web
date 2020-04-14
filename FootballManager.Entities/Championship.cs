using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballManager.Entities
{
     public class Championship
     {
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Key]
        public int ID { get; set; }
        public string Name { get; set; }
     }
}
