//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NEST_App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Configuration
    {
        public Configuration()
        {
            this.Vehicle = new HashSet<UAV>();
            this.EquipmentLists = new HashSet<Equipment>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Classification { get; set; }
        public byte NumberOfMotors { get; set; }
        public System.DateTime create_date { get; set; }
        public System.DateTime modified_date { get; set; }
    
        public virtual ICollection<UAV> Vehicle { get; set; }
        public virtual ICollection<Equipment> EquipmentLists { get; set; }
    }
}
