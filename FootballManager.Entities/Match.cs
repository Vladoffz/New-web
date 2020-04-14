using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballManager.Entities
{
     public class Match
     {
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Key]
         public int MatchID { get; set; }
        
         [DataType(DataType.Date)]
         public DateTime PlayableDate { get; set; }
        public int Result { get; set; }
        public int CommandID { get; set; }
        [ForeignKey("CommandID")]
        public virtual ICollection<Command> Commands { get; set; }
     }
}
