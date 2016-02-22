using System.Xml.Serialization;

namespace CrossCompat.Core.Models
{
	[XmlRoot(ElementName="generator", Namespace="http://www.w3.org/2005/Atom")]
	public class Generator {
		[XmlAttribute(AttributeName="uri")]
		public string Uri { get; set; }
		[XmlAttribute(AttributeName="version")]
		public string Version { get; set; }
		[XmlText]
		public string Text { get; set; }
	}
}
