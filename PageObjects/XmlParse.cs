namespace PageObjects.Tests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class XmlParse
    {
        private const string XmlFilename = "response.xml";
        private string currentDirectory;
        private string responseFilePath;
        private XElement response;

        [SetUp]
        public void Setup()
        {
            this.currentDirectory = Directory.GetCurrentDirectory();
            this.responseFilePath = Path.Combine(this.currentDirectory, XmlFilename);
            this.response = XElement.Load(this.responseFilePath);
        }

        [Test]
        public void XmlElementsTest()
        {
            IEnumerable<XElement> elements = this.response.Elements();

            foreach (var item in elements)
            {
                Console.WriteLine(item.Element("XAMOUNT").Value);
            }
        }

        [Test]
        public void XmlNestedElementsTest()
        {
            IEnumerable<XElement> nestedElements = this.response.Descendants("XAMOUNT");

            foreach (var item in nestedElements)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
