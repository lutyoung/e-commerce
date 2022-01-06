using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCom.Web.Models
{
    public class Admin:BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
