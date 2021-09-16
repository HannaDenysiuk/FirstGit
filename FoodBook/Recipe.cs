using System.Xml.Serialization;
namespace FoodBook
{
    [XmlRoot(ElementName = "recipe")]
	public class Recipe
	{
		[XmlElement(ElementName = "Title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "Ingredients")]
		public Ingredients Ingredients { get; set; }
		[XmlElement(ElementName = "Preparation")]
		public Preparation Preparation { get; set; }
		[XmlElement(ElementName = "Serving")]
		public string Serving { get; set; }
        public override string ToString()
        {
            return $"\nTitle: {Title}\nServing: {Serving}\n\ningredients: {Ingredients}\nPreparation: {Preparation}\n";
        }
    }
}
