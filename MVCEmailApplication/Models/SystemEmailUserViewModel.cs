using System.Collections.Generic;

namespace MVCEmailApplication.Models
{
    public class SystemEmailUserViewModel
    {
        public ApplicationUser User { get; set; }
        public IEnumerable<SystemEmail> SystemEmails { get; set; }
    }
}