using System;

namespace Task_4
{
    //[Serializable]
    public class Car
    {
        public string  Model { get; set; }
        public string  Number { get; set; }
        public string Color { get; set; }
        public Car()
        {

        }
        public override string ToString()
        {
            return $"\nmodel: {Model}\nnumber: {Number}\ncolor: {Color}\n";
        }
    }
}
