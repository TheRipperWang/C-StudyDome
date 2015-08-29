#region 
/************************************************************************/
/* 文件名称：ReferenceDome
/* 作   者：王成
/* 创建时间：2015/08/29       
/************************************************************************/
#endregion
using System;
using System.Text;

namespace ReferenceDome
{
    internal class Program
    {
        private static void Main( string[] args )
        {
            StringBuilder name = new StringBuilder( );
            //name.Append( "dsds" );
            //name.Append( "sdsd" );
            name.Append( "wangcheng" );
            name.Append( "love" );
            name.Append( "renjie" );

            Console.WriteLine( name.Length );
            Console.WriteLine( name );

            Console.WriteLine( "按任意键退出..." );
            Console.ReadKey( );
        }
    }
}