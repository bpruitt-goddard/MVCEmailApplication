using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEmailApplication.Models
{
    public class SystemEmailUserViewModel
    {
        public ApplicationUser User { get; set; }
        public IEnumerable<SystemEmail> SystemEmails { get; set; }
    }
}