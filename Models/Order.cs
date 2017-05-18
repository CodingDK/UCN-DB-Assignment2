using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models {
    public class Order {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public List<OrderLine> Lines { get; set; }

    }
}
