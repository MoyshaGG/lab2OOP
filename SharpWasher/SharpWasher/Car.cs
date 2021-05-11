using System;
using System.Collections.Generic;
using System.Text;

namespace SharpWasher
{
    class Car
    {
        public string name { get; set; }
        public bool clean { get; set; }

        public Car(string name)
        {
            this.name = name;
            this.clean = false;
        }
        public Car(string name, bool clean)
        {
            
            this.name = name;
            this.clean = clean;
        }

        public override string ToString()
        {
            if(clean)
            {
                return name + " - Чиста";
            }
            else
            {
                return name + " - Забруднена";
            }
        }

    }

}
