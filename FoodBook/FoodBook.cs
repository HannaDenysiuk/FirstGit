using System.Xml.Serialization;
using System.Collections.Generic;
namespace FoodBook
{
    [XmlRoot(ElementName = "FoodBook")]
	public class FoodBook
	{
		[XmlElement(ElementName = "recipe")]
		public List<Recipe> Recipe { get; set; }
        public override string ToString()
        {
            return string.Join(new string('=',50),Recipe);
        }
    }
}
