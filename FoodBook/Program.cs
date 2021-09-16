using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace FoodBook
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("привіт");

            FoodBook foodBook = null;
            XmlSerializer xs = new XmlSerializer(typeof(FoodBook));
            using (FileStream fs = new FileStream("FOOD.xml", FileMode.Open))
            {
                foodBook = (FoodBook)xs.Deserialize(fs);
            }
            Console.WriteLine(foodBook);
            Console.WriteLine("привіт дивний світ їжаків та ґедзів"); 
        }
    }
}
