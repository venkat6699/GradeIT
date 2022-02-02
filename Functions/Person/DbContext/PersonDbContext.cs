using Microsoft.EntityFrameworkCore;
using System;

namespace Person
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options)
        { }

        public DbSet<Person> Person { get; set; }                
    }

    public class Person
    {
        public Person()
        {
            this.Status = true;
        }
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public DateTime DOB { get; set; }
        public Boolean Status { get; set; }
    }
}
