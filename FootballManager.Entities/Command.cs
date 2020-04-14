using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballManager.Entities
{
    public class Command
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CommandID { get; set; }
        [ForeignKey("PlayerID")]
        public int PlayerID { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        [ForeignKey("PlayerID")]
        public virtual ICollection<Player> Players { get; set; }
    }
}
