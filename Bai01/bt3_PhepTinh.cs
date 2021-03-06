using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class bt3_PhepTinh
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());
            var tong = a + b;
            Console.WriteLine($"Tổng = {tong}");
        }
    }
}
