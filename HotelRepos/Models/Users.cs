﻿using System.Numerics;

namespace HotelRepos.Models
{
    public class Users
    {
    
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Login { get; set; }

        public string? Password { get; set; }

        public string? Salt { get; set; }
       
    public ICollection<Messages>? messages { get; set; }
}
}