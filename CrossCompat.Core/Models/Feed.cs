using System.Xml.Serialization;
using System.Collections.Generic;

namespace CrossCompat.Core.Models
{
	[XmlRoot(ElementName="feed", Namespace="http://www.w3.org/2005/Atom")]
	public class Feed {
		[XmlElement(ElementName="generator", Namespace="http://www.w3.org/2005/Atom")]
		public Generator Generator { get; set; }
		[XmlElement(ElementName="link", Namespace="http://www.w3.org/2005/Atom")]
		public List<Link> Link { get; set; }
		[XmlElement(ElementName="updated", Namespace="http://www.w3.org/2005/Atom")]
		public string Updated { get; set; }
		[XmlElement(ElementName="id", Namespace="http://www.w3.org/2005/Atom")]
		public string Id { get; set; }
		[XmlElement(ElementName="title", Namespace="http://www.w3.org/2005/Atom")]
		public string Title { get; set; }
		[XmlElement(ElementName="subtitle", Namespace="http://www.w3.org/2005/Atom")]
		public string Subtitle { get; set; }
		[XmlElement(ElementName="entry", Namespace="http://www.w3.org/2005/Atom")]
		public List<Entry> Entry { get; set; }
		[XmlAttribute(AttributeName="xmlns")]
		public string Xmlns { get; set; }
	}
}
