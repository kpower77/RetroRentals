namespace Retro_Rentals.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Membership
    {
        public int MembershipId { get; set; }
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public Grade? Grade { get; set; }

        public Movie Movie { get; set; }
        public Customer Customer { get; set; }
    }
}
