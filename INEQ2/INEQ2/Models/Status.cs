using BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ2.Models
{
    public class Status
    {
        public int ID { get; set; }
        public String Description { get; set; }
        public ActivationContext Active { get; set; }

        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}