using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyperProject.Entity
{
public enum Headlight
{
    OFF, ON
}
    public class Car : Vehicle
    {
        public int Wheels { get; set; }
        public bool HeadlightsOn { get; set; }
    }

}