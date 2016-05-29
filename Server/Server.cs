using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [Guid("A1079652-CAFA-42AD-92CC-F9331471D070")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IServer
    {
        void SetPos(ref Point pt);
        Point GetPos();
        void SetX(int x);
        int GetX();

    }

    [
        Guid("F92A0436-D8CF-4BF4-8483-EAA185EF372F"),
        ComVisible(true), 
        ProgId("Server.Server"),
        ClassInterface(ClassInterfaceType.None)
    ]

    public class Server : IServer
    {
        public Server()
        {
            _pt = Point.Empty;
        }
        private Point _pt;

        public void SetPos(ref Point pt)
        {
            _pt = pt;
        }

        public Point GetPos()
        {
            return _pt;
        }
        
        public void SetX(int x)
        {
            _pt.X = x;
        }
        
        public int GetX()
        {
            return _pt.X;
        }


    }
}
