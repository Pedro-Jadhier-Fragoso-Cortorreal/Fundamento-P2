using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace WorkingWithXL
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\WikimediaExample.xml");
            //UsingXmlReader(Path);
            //UsingXmlDocument(path);
            UsingXmlDocumentWithXPath(path);
        }
        private static void UsingXmlReader(string path)
        {
            XmlReader xmlReader = XmlReader.Create(path);

            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "project"))
                {
                    if (xmlReader.HasAttributes)
                        Console.WriteLine(xmlReader.GetAttribute("name") + " : " + xmlReader.GetAttribute("launch"));

                }
                else if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "edition"))
                {
                    if (xmlReader.HasAttributes)
                        Console.WriteLine(xmlReader.GetAttribute("language"));
                }
            }

            Console.ReadKey();

        }

        private static void UsingXmlDocument(string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[0].ChildNodes)
            {
                Console.WriteLine(xmlNode.Attributes["name"].Value + " : " + xmlNode.Attributes["launch"].Value);

                foreach (XmlNode xmlNodeItem in xmlNode.FirstChild.ChildNodes)
                {
                    Console.WriteLine(xmlNodeItem.Attributes["language"].Value);

                    Console.WriteLine("Inner Text :" + xmlNodeItem.InnerText);
                    Console.WriteLine("Inner Xml: " + xmlNodeItem.InnerXml);
                    Console.WriteLine("Outer Xml : " + xmlNodeItem.OuterXml);
                }
            }

        }

        private static void UsingXmlDocumentWithXPath(string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNodeList itemNodes = xmlDoc.SelectNodes("//Wikimedia//projects//project");
            foreach (XmlNode itemNode in itemNodes)
            {
                Console.WriteLine(itemNode.Attributes["name"].Value + " : " + itemNode.Attributes["launch"].Value);

                foreach (XmlNode item in itemNode.SelectSingleNode("editions"))
                {
                    Console.WriteLine(item.Attributes["language"].Value);
                }

            }

            Console.ReadKey();
        }
    }
}