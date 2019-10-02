using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet4.Models
{
    public class Order
    {
        public SubType type { get; set; }
        public SubSize size { get; set; }

        public IEnumerable<SelectListItem> TypeList { get; set; }
        public IEnumerable<string> SelectedType { set; get; }

        public String deal { get; set; }
        /*
        public Boolean dealnone { get; set; }
        public Boolean deal1 { get; set; }
        public Boolean deal2 { get; set; }

    */

    }


    public enum SubType
    {
        Peperonie, Cheese, Alldress, Vege
    }

    public enum SubSize
    {
        Small, Medium, Large, XLarge
    }
}