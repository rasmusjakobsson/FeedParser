using System;
using System.Xml.Serialization;

namespace RssFeed.Models
{
    public class RssFeed
    {
        [XmlElement(ElementName = "channel")]
        public Channel[] Channel { get; set; }

    }
    [XmlRoot(ElementName = "channel")]
    public class Channel
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "description")]
        public string Desctription { get; set; }
        [XmlElement(ElementName = "item")]
        public Item[] Items { get; set; }
    }
    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlElement(ElementName = "enclosure")]
        public Enclosure Enclosure { get; set; }

    }


    [XmlRoot(ElementName = "enclosure")]
    public class Enclosure
    {
        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }
        [XmlAttribute(AttributeName = "length")]
        public string Length { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

    }
}