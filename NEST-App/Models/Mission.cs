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
    
    public partial class Mission
    {
        public Mission()
        {
            this.Orders = new HashSet<Order>();
            this.MissionLogs = new HashSet<MissionLog>();
            this.Waypoints = new HashSet<Waypoint>();
        }
    
        public string Phase { get; set; }
        public string FlightPattern { get; set; }
        public string Payload { get; set; }
        public int Priority { get; set; }
        public Nullable<decimal> FinancialCost { get; set; }
        public Nullable<System.DateTime> TimeAssigned { get; set; }
        public Nullable<System.DateTime> TimeCompleted { get; set; }
        public Nullable<System.DateTime> ScheduledCompletionTime { get; set; }
        public Nullable<System.DateTime> EstimatedCompletionTime { get; set; }
        public int id { get; set; }
        public int ScheduleId { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> modified_date { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<MissionLog> MissionLogs { get; set; }
        public virtual ICollection<Waypoint> Waypoints { get; set; }
    }
}
