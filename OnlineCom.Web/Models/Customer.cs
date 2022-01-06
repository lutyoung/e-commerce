using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCom.Web.Models
{
    public class Customer:BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public string CustomerNumber { get; set; }
    }
}
