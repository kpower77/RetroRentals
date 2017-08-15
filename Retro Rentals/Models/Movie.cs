using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Retro_Rentals.Models
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MovieId { get; set; }
        public string Title { get; set; }
        
        public ICollection<Membership> Memberships { get; set; }
    }
}
