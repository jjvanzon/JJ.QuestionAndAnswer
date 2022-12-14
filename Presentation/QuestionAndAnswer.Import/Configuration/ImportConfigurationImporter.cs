using System.Xml.Serialization;

namespace JJ.Presentation.QuestionAndAnswer.Import.Configuration
{
    public class ImportConfigurationImporter
    {
        [XmlAttribute]
        public string InputFilePath { get; set; }

        [XmlAttribute]
        public string SourceIdentifier { get; set; }

        [XmlAttribute]
        public string SourceUrl { get; set; }

        [XmlAttribute]
        public string SourceDescription { get; set; }

        [XmlAttribute]
        public string ModelType { get; set; }

        [XmlAttribute]
        public string SelectorType { get; set; }

        [XmlAttribute]
        public string ConverterType { get; set; }

        [XmlAttribute]
        public string CategoryPath { get; set; }
    }
}
