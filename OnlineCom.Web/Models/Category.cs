using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCom.Web.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public int DisplayOrder { get; set; }
    }
}
