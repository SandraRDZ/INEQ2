using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ2.Models
{
    public class Warehouse
    {
        public int ID { get; set;  }
        public String Descripcion { get; set; }
        public int IS { set; get; }
        public String Responsable { get; set; }
        public Boolean Active { get; set; }

        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}