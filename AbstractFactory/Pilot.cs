using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    internal abstract class Pilot
    {
        public string _pilotname;

        public Pilot(string pilotname)
        {
            _pilotname = pilotname;
           
        }
    }
}
