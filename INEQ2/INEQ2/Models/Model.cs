using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ2.Models
{
    public class Model
    {
        public int ID { get; set; }
        public String Descripcion { get; set; }
        public int BrandId { get; set; }
        public Boolean Active { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}