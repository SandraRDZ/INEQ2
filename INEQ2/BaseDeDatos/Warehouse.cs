//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaseDeDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouse()
        {
            this.Equipments = new HashSet<Equipment>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public string IS { get; set; }
        public string Responsable { get; set; }
        public bool Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}
