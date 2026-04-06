using System;
using System.Text;
using System.Collections.Generic;


namespace App.Core.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Customer()
        {
            //sample: 123e4567-e89b-12d3-a456-426614174000
            Id = "C-" + Guid.NewGuid().ToString("N").Substring(0 , 9);
        }
    }
}
