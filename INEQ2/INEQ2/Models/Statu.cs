using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ2.Models
{
    public class Statu
    {
        public int ID { get; set; }
        public String Descripcion { get; set; }
        public Boolean Activar { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}