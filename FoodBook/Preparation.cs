using System.Xml.Serialization;
namespace FoodBook
{
    [XmlRoot(ElementName = "Preparation")]
	public class Preparation
	{
		[XmlAttribute(AttributeName = "degree_of_complexity")]
		public string Degree_of_complexity { get; set; }
		[XmlAttribute(AttributeName = "cooking_time")]
		public string Cooking_time { get; set; }
		[XmlText]
		public string Text { get; set; }

        public override string ToString()
        {
            return $"Degree of complexity: {Degree_of_complexity}\nCooking time: {Cooking_time}\nPreparation: {Text}\n";
        }
    }
}
