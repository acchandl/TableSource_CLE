using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TableSource_CLE.Models
{
    public class Category
    {
        [Key]
        public int categoryID { get; set; }
        public string categoryName { get; set; }

        //Navigation Properties
        public virtual ICollection<Donation> Donations { get; set; }
    }
}