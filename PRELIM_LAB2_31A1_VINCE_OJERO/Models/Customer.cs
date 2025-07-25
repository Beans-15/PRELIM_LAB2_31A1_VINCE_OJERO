﻿namespace PRELIM_LAB2.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}

