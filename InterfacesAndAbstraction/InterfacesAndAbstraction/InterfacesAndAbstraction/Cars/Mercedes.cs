using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstraction.Cars
{
    public class Mercedes: ICar
    {
        public string Model { get; }

        public Mercedes(string model)
        {
           this. Model = model;
        }

        public string Start()
        {
            return "Whrom!";
        }

        public string Stop()
        {
            return "Stop";
        }

        public override string ToString()
        {
            return "Mercedes";
        }
    }
}
