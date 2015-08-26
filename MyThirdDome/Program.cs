using System;
using System.Xml;

namespace WriteXml
{
    internal class Program
    {
        private static void CreaTeXml( string title , string author , string price )
        {
            XmlTextWriter writer = new XmlTextWriter( "titles.xml" , null );
            //使用自动缩进便于阅读
            writer.Formatting = Formatting.Indented;

            //写入根元素
            writer.WriteStartElement( "items" );
            writer.WriteStartElement( "item" );
            //写入属性及属性的名字
            writer.WriteAttributeString( "类别" , "小说" );
            writer.WriteAttributeString( "品质" , "经典" );
            //加入子元素
            writer.WriteElementString( "title" , title );
            writer.WriteElementString( "author" , author );
            writer.WriteElementString( "price" , price );
            //关闭根元素，并书写结束标签
            writer.WriteEndElement( );
            writer.WriteEndElement( );
            //将XML写入文件并且关闭XmlTextWriter
            writer.Close( );
        }

        private static void Main( string[] args )
        {
            string title = "王成著";
            string author = "王成";
            string price = "10";

            CreaTeXml( title , author , price );

            ReadText( );

            Console.WriteLine( "\n按任意键退出..." );
            Console.ReadKey( );
        }

        private static void ReadText( )
        {
            XmlDocument xmlDoc = new XmlDocument( );
            xmlDoc.Load( "titles.xml" );
            XmlNode xn = xmlDoc.SelectSingleNode( "items" );

            XmlNodeList xnl = xn.ChildNodes;

            foreach ( XmlNode xnf in xnl )
            {
                XmlElement xe = ( XmlElement )xnf;
                Console.WriteLine( "类别:{0}" , xe.GetAttribute( "类别" ) );//显示属性值
                Console.WriteLine( "品质:{0}" , xe.GetAttribute( "品质" ) );

                XmlNodeList xnf1 = xe.ChildNodes;
                foreach ( XmlNode xn2 in xnf1 )
                {
                    Console.WriteLine( );//显示子节点点文本
                }
                Console.WriteLine( );
            }
        }
    }
}