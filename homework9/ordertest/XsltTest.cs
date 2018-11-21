using System;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
class Test
{
    static void Main2()
    {
        try
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@".\ordersTarget.xml");

            XPathNavigator nav = doc.CreateNavigator();
            nav.MoveToRoot();

            XslTransform xt = new XslTransform();
            xt.Load(@".\ordersTarget.xslt");

            XmlTextWriter writer = new XmlTextWriter(Console.Out);

            xt.Transform(nav, null, writer);
        }
        catch (XmlException e)
        {
            Console.WriteLine("XML Exception:" + e.ToString());
        }
        catch (XsltException e)
        {
            Console.WriteLine("XSLT Exception:" + e.ToString());
        }

    }

}