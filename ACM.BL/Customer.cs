﻿namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string EmailAddress { get; set; }


    }
}