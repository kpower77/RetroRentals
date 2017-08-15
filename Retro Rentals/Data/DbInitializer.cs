using Retro_Rentals.Models;
using System;
using System.Linq;

namespace Retro_Rentals.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Customers.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
            new Customer{FirstName="Carl",SurName="O'Reilly",MembershipDate=DateTime.Parse("2015-03-03")},
            new Customer{FirstName="Alan",SurName="Murphy",MembershipDate=DateTime.Parse("2015-09-13")},
            new Customer{FirstName="Edel",SurName="O'Brien",MembershipDate=DateTime.Parse("2014-10-14")},
            new Customer{FirstName="Bernedette",SurName="Walsh",MembershipDate=DateTime.Parse("2013-05-23")},
            new Customer{FirstName="Laura",SurName="McCarty",MembershipDate=DateTime.Parse("2012-07-18")}
            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

            var movies = new Movie[]
            {
            new Movie{MovieId=1050,Title="Chemistry"},
            new Movie{MovieId=1050,Title="Chemistry"},
            new Movie{MovieId=1050,Title="Chemistry"},
            new Movie{MovieId=1050,Title="Chemistry"},
            new Movie{MovieId=1050,Title="Chemistry"}
            };
            foreach (Movie v in movies)
            {
                context.Movies.Add(v);
            }
            context.SaveChanges();

            var memberships = new Membership[]
            {
            new Membership{CustomerId=1,MovieId=1050,Grade= Grade.A },
            new Membership{CustomerId=1,MovieId=1050,Grade= Grade.A },
            new Membership{CustomerId=1,MovieId=1050,Grade= Grade.A },
            new Membership{CustomerId=1,MovieId=1050,Grade= Grade.A },
            new Membership{CustomerId=1,MovieId=1050,Grade= Grade.A }
            };
            foreach (Membership e in memberships)
            {
                context.Memberships.Add(e);
            }
            context.SaveChanges();
        }
    }
}
