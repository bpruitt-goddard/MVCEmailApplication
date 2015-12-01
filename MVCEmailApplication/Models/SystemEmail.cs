using System;
using System.Data.Entity;

namespace MVCEmailApplication.Models
{
    public class SystemEmail
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public string Subject { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime? OpenedDate { get; set; }
    }

    public class SystemEmailDbContext : DbContext
    {
        public SystemEmailDbContext()
            : base("DefaultConnection")
        {
            
        }
        
    }
}