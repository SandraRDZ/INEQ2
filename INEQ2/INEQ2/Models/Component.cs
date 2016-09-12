using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ2.Models
{
    public class Component
    {
        public int Id { get; set; }
        public int EquipmentTypeId { get; set; }
        public Boolean Active { get; set; }
        public String Descripcion { get; set; }
        public int EquipmentId { get; set; }
        public int ComponentTypeId { get; set; }


        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}