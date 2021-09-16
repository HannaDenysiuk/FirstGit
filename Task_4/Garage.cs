using System;
using System.Collections.Generic;

namespace Task_4
{
    //[Serializable]
    public class Garage
    {
        public List<Car> Cars
        {
            get; set;
        }
        public Garage()
        {

        }
        public override string ToString()
        {
            return string.Join(new string('-', 20), Cars);
        }
    }
}
