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
    
    public partial class CMD_NAV_Return
    {
        public CMD_NAV_Return()
        {
            this.Acked = false;
        }
    
        public int Id { get; set; }
        public double Altitude { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Throttle { get; set; }
        public int UAVId { get; set; }
        public bool Acked { get; set; }
    }
}
