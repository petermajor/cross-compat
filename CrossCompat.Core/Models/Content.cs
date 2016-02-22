using System.Xml.Serialization;

namespace CrossCompat.Core.Models
{
	[XmlRoot(ElementName="content", Namespace="http://www.w3.org/2005/Atom")]
	public class Content {
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName="base", Namespace="http://www.w3.org/XML/1998/namespace")]
		public string Base { get; set; }
		[XmlText]
		public string Text { get; set; }
	}
}
