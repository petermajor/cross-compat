using System.Xml.Serialization;

namespace CrossCompat.Core.Models
{
	[XmlRoot(ElementName="category", Namespace="http://www.w3.org/2005/Atom")]
	public class Category {
		[XmlAttribute(AttributeName="term")]
		public string Term { get; set; }
	}
}
