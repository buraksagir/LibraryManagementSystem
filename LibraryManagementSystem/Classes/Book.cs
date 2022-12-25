using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    public class Book
    {
        public int BID { get; set; }
        public string Title{ get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool Availability { get; set; }
        //public string IssueDate { get; set; }
        //public int ReturnDate { get; set; }
        public bool IfDeleted { get; set; }
    }
}
