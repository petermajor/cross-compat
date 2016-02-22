using System.Xml.Serialization;

namespace CrossCompat.Core.Models
{
	[XmlRoot(ElementName="link", Namespace="http://www.w3.org/2005/Atom")]
	public class Link {
		[XmlAttribute(AttributeName="href")]
		public string Href { get; set; }
		[XmlAttribute(AttributeName="rel")]
		public string Rel { get; set; }
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName="title")]
		public string Title { get; set; }
	}
}
