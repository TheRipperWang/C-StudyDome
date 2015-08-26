using System;
using System.Xml;

namespace MySecondDome
{
    internal class Program
    {
        private static void Main( string[] args )
        {
            Console.WriteLine( "信息登记系统\n" );

            Console.WriteLine( "你好，欢迎使用信息登记系统" );
            Console.WriteLine( "" );

            Console.WriteLine( "按任意键退出..." );
            Console.ReadKey( );
        }

        private static void WriteXml( )
        {
            XmlTextWriter writer = new XmlTextWriter( "message.xml" , null );
            //创建xml存储数据

            writer.Formatting = Formatting.Indented;

            writer.WriteStartElement( "items" );
        }
    }
}