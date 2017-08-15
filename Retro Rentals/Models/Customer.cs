using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Retro_Rentals.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string SurName { get; set; }

        [Display(Name = "Membership Date")]
        public DateTime MembershipDate { get; set; }

        public ICollection<Membership> Memberships { get; set; }
    }
}
