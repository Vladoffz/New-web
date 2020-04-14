using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballManager.Entities
{
    public class ChampionshipCommand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ChampionshipCommandID { get; set; }
        [ForeignKey("ChampionshipID")]
        public int ChampionshipID { get; set; }
        [ForeignKey("CommandID")]
        public int CommandID { get; set; }

        public Command Command { get; set; }
        public Championship Championship { get; set; }
    }
}
