using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HyperProject.Entity
{

public enum VehicleColor
{
    [Description("Red")]
    Red,
    [Description("Blue")]
    Blue,
    [Description("Black")]
    Black,
    [Description("White")]
    White
}


    public abstract class Vehicle
    {
        public int Id { get; set; }
        public VehicleColor Color { get; set; }
    }
}