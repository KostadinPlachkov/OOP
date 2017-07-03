using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstraction.Cars
{
    class Tesla: ICar
    {
        public string Model { get; }

        public Tesla(string model)
        {
            this.Model = model;
        }


        public string Start()
        {
            return "...";
        }

        public string Stop()
        {
            return "...";
        }

        public override string ToString()
        {
            return "Tesla";
        }
    }
}
