﻿namespace FameFindsWebServices.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string? FullName { get; set; }

        public string? Email { get; set; }

        public string? PasswordHash { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
