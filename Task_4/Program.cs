using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Создать .xml файл с информацией о нескольких автомобилях.
            Создать класс Car. Создать класс Garage, 
            в котором имеется список автомобилей.
            С помощью класса XmlTextReader считать информацию о всех автомобилях и вывести в консоль.
            При виходе из программы вся информация о автомобилях сохраняется в новый .xml файл.*/


            Garage garage = new Garage();

            XmlSerializer formatter = new XmlSerializer(typeof(Garage));
            using (FileStream fs = new FileStream("MyNewGarage.xml", FileMode.Open))
            {
                garage = (Garage)formatter.Deserialize(fs);

            }
            Console.WriteLine(garage);
            using (FileStream fs = new FileStream("Cars.xml", FileMode.OpenOrCreate))
            {
               formatter.Serialize(fs,garage);

            }

            garage.Cars.Add(new Car { Color = "gray", Model = "Nyva", Number = "AT9933" });
            using (FileStream fs = new FileStream("Cars.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, garage);

            }
            Console.WriteLine(new string('+',30));
            using (FileStream fs = new FileStream("Cars.xml", FileMode.Open))
            {
                garage = (Garage)formatter.Deserialize(fs);

            }
            Console.WriteLine(garage);
        }
    }
}
