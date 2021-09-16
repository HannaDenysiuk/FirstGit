using System.Xml.Serialization;
namespace FoodBook
{
    [XmlRoot(ElementName = "Item")]
	public class Item
	{
		[XmlAttribute(AttributeName = "gram")]
		public string Gram { get; set; }
		[XmlText]
		public string Text { get; set; }
		[XmlAttribute(AttributeName = "liters")]
		public string Liters { get; set; }
		[XmlAttribute(AttributeName = "pieces")]
		public string Pieces { get; set; }
		[XmlAttribute(AttributeName = "piece")]
		public string Piece { get; set; }
		[XmlAttribute(AttributeName = "tea-spun")]
		public string Teaspun { get; set; }
		[XmlAttribute(AttributeName = "kilogram")]
		public string Kilogram { get; set; }
		[XmlAttribute(AttributeName = "pods")]
		public string Pods { get; set; }
		[XmlAttribute(AttributeName = "heads")]
		public string Heads { get; set; }
        public override string ToString()
        {
            return $"{Text} - {Gram}{Liters}{Pieces}{Piece}{Teaspun}{Kilogram}{Pods}{Heads}";
        }
    }
}
