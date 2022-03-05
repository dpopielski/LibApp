using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LibApp.Models;

namespace LibApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)

        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
            builder.Entity<Customer>().HasData(

                new Customer
                {
                    Id = 1,
                    Name = "Adam Malysz",
                    Birthdate = new DateTime(2001, 1, 1),
                    HasNewsletterSubscribed = false,
                    MembershipTypeId = 1

                },
                new Customer
                {
                    Id = 2,
                    Name = "Kamil Stoch",
                    Birthdate = new DateTime(2002, 2, 2),
                    HasNewsletterSubscribed = false,
                    MembershipTypeId = 2

                },
                new Customer
                {
                    Id = 3,
                    Name = "Dawid Kubacki",
                    Birthdate = new DateTime(2003, 3, 3),
                    HasNewsletterSubscribed = false,
                    MembershipTypeId = 3

                }
                );
            builder.Entity<Book>().HasData(
            new Book
            {
                Id = 5,
                Name = "Asp.Net",
                GenreId = 2,
                AuthorName = "Krzysztof Krawczyk",
                DateAdded = new DateTime(2000, 1, 12),
                ReleaseDate = new DateTime(1999, 1, 10)

            },
            new Book
            {
                Id = 6,
                Name = "Parostatek",
                GenreId = 1,
                AuthorName = "Krzysztof Krawczyk",
                DateAdded = new DateTime(2000, 1, 12),
                ReleaseDate = new DateTime(1999, 1, 10)

            }

            ) ; 
        }
    }
}
