using System;
namespace Staff.Models
{
    public class Staff
    {
        public Staff()
        {
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}
