using System.Xml.Serialization;
using System.Collections.Generic;
namespace FoodBook
{
    [XmlRoot(ElementName = "Ingredients")]
	public class Ingredients
	{
		[XmlElement(ElementName = "Item")]
		public List<Item> Item { get; set; }
        public override string ToString()
        {
            return string.Join("\n",Item);
        }
    }
}
