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
    
    public partial class DeliveryStatus
    {
        public int Id { get; set; }
        public string time_departure { get; set; }
        public string location_departure { get; set; }
        public string sta { get; set; }
        public string eta { get; set; }
        public string cargo_number { get; set; }
        public string status_comment { get; set; }
        public string time_return { get; set; }
        public string time_delivery { get; set; }
    
        public virtual Schedule Schedule { get; set; }
    }
}
