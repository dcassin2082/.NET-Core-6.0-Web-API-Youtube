using System;
using System.Collections.Generic;

namespace WebApplication32.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Email { get; set; }
        public string? Address2 { get; set; }
        public string? Phone { get; set; }
        public string? Phone2 { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? OrderCount { get; set; }
        public decimal? OrderAggregateProductTotal { get; set; }
    }
}
