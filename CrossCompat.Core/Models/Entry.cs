using System.Xml.Serialization;
using System.Collections.Generic;
using System;


namespace CrossCompat.Core.Models
{
	[XmlRoot(ElementName="entry", Namespace="http://www.w3.org/2005/Atom")]
	public class Entry {
		[XmlElement(ElementName="title", Namespace="http://www.w3.org/2005/Atom")]
		public string Title { get; set; }
		[XmlElement(ElementName="link", Namespace="http://www.w3.org/2005/Atom")]
		public Link Link { get; set; }
		[XmlElement(ElementName="published", Namespace="http://www.w3.org/2005/Atom")]
		public DateTime Published { get; set; }
		[XmlElement(ElementName="updated", Namespace="http://www.w3.org/2005/Atom")]
		public DateTime Updated { get; set; }
		[XmlElement(ElementName="id", Namespace="http://www.w3.org/2005/Atom")]
		public string Id { get; set; }
		[XmlElement(ElementName="content", Namespace="http://www.w3.org/2005/Atom")]
		public Content Content { get; set; }
		[XmlElement(ElementName="author", Namespace="http://www.w3.org/2005/Atom")]
		public Author Author { get; set; }
		[XmlElement(ElementName="category", Namespace="http://www.w3.org/2005/Atom")]
		public List<Category> Category { get; set; }
		[XmlElement(ElementName="summary", Namespace="http://www.w3.org/2005/Atom")]
		public string Summary { get; set; }
	}
}
