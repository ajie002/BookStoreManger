using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryMIS.Models
{
    class BookModel
    {
        public string BID { get; set; }
        public string BName { get; set; }
        public string BWriter { get; set; }
        public string BPublish { get; set; }
        public DateTime BDate { get; set; }
        public string BPrice { get; set; }
        public string BNum { get; set; }
        public string Type { get; set; }
        public string BRemark { get; set; }
    }
}
