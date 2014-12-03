﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Spatial;
using NEST_App.Models;

namespace NEST_App.DAL
{
    public class NestDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<NestDbContext>
    {
        protected override void Seed(NestDbContext context)
        {

            var UAVs = new List<UAV>
            {
                new UAV{Callsign = "HAWK21", NumDeliveries = 2134, Mileage = 234, Id = 0},
                new UAV{Callsign = "CROW10", NumDeliveries = 1234, Mileage = 111, Id = 1},
                new UAV{Callsign = "PINR44", NumDeliveries = 3301, Mileage = 044, Id = 2},
                new UAV{Callsign = "BIRD00", NumDeliveries = 2215, Mileage = 591, Id = 3}
            };
            UAVs.ForEach(s => context.UAVs.Add(s));

            var FlightStates = new List<FlightState>
            {
                new FlightState{ Position = DbGeography.FromText("POINT(-118.5002736 34.2365205 400)"), VelocityX = 0, VelocityY = 0, VelocityZ = 0, Yaw = 0, Roll = 0, Pitch = 0, YawRate = 0, RollRate = 0, PitchRate = 0, BatteryLevel = .94, UAVId = 0 },
                new FlightState{ Position = DbGeography.FromText("POINT(-118.5002736 34.2365205 400)"), VelocityX = 0, VelocityY = 0, VelocityZ = 0, Yaw = 0, Roll = 0, Pitch = 0, YawRate = 0, RollRate = 0, PitchRate = 0, BatteryLevel = .84, UAVId = 1 },
                new FlightState{ Position = DbGeography.FromText("POINT(-118.5002736 34.2365205 400)"), VelocityX = 0, VelocityY = 0, VelocityZ = 0, Yaw = 0, Roll = 0, Pitch = 0, YawRate = 0, RollRate = 0, PitchRate = 0, BatteryLevel = .82, UAVId = 2 },
                new FlightState{ Position = DbGeography.FromText("POINT(-118.5002736 34.2365205 400)"), VelocityX = 0, VelocityY = 0, VelocityZ = 0, Yaw = 0, Roll = 0, Pitch = 0, YawRate = 0, RollRate = 0, PitchRate = 0, BatteryLevel = .74, UAVId = 3 }
            };
            FlightStates.ForEach(s =>
            {
                s.Timestamp = DateTime.Now;
                context.FlightStates.Add(s);
            });
            DateTime dateValue = new DateTime();
            dateValue = DateTime.Now;
            var missions = new List<Mission>
            {
                new Mission{Phase = "enroute", FlightPattern = "abstract", Payload = "cheetos", Priority = 1, FinancialCost = 40, UAVAssigned = 1, TimeAssigned = DateTime.Now, TimeCompleted = dateValue.AddHours(0.0833), DestinationCoordinates = DbGeography.FromText("POINT(-118.5002736 34.2365205 400)"),  ScheduledCompletionTime = dateValue.AddHours(0.0899), EstimatedCompletionTime = dateValue.AddHours(0.09)  },
                new Mission{Phase = "enroute", FlightPattern = "abstract", Payload = "cheetos", Priority = 1, FinancialCost = 40, UAVAssigned = 1, TimeAssigned = DateTime.Now, TimeCompleted = dateValue.AddHours(0.0833), DestinationCoordinates = DbGeography.FromText("POINT(-118.5002736 34.2365205 400)"),  ScheduledCompletionTime = dateValue.AddHours(0.0899), EstimatedCompletionTime = dateValue.AddHours(0.09)  }

            };
            missions.ForEach(s => context.Missions.Add(s));

            context.SaveChanges();
        }
    }
}