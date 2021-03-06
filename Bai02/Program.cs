using System;
using System.Text;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder("Tâm");
            StringBuilder sb2;
            sb2 = sb1;
            sb1 = null;
        }
    }
}
