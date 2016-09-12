using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ2.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public int EquipmentTypeId { get; set; }
        public int ModelId { get; set; }
        public int BrandId { get; set; }
        public int StatusId { get; set; }
        public int WarehouseId { get; set; }
        public DateTime EntryDate { get; set; }
        public string Serie { get; set; }
        public string SofttekId { get; set; }
        public Boolean Active { get; set; }

        public virtual ICollection<Brand> Brand { get; set; }
        public virtual ICollection<Component> Components { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<Model> Models { get; set; }
        public virtual ICollection<Status> Status { get; set; }
        public virtual ICollection<Warehouse> Warehouse { get; set; }

    }
}