using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace cs_union_test
{
    class Program
    {

        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public struct Union
        {
            [FieldOffset(0)]
            public Byte b0;
            [FieldOffset(1)]
            public Byte b1;
            [FieldOffset(2)]
            public Byte b2;
            [FieldOffset(3)]
            public Byte b3;
            [FieldOffset(0)]
            public Int32 i;
            [FieldOffset(0)]
            public Single f;
        }


        static void Main(string[] args)
        {
            // 返回：AA 01 00 00 00 82 23 7D 32 03 00 00 06 光功率：Tx_Buf[5  6  7  8 ]
            //  -34.08 dBm:   0x70 0xb0 0xcc 0x39  --- 0.00039 mW;  
            Union u = new Union();
            u.b0 = 0x70;  //Tx_Buf[5  6  7  8 ]   
            u.b1 = 0xb0;
            u.b2 = 0xcc;
            u.b3 = 0x39;
            
            Console.WriteLine(Convert.ToString(  u.f ) );    //mW
            Console.WriteLine((Double.Parse( Convert.ToString(10*Math.Log10(u.f)) ).ToString("F3")));    //dBm  
            Console.WriteLine((Double.Parse(Convert.ToString(10 * Math.Log(u.f))).ToString("F2")));   // dBw


            Console.ReadKey();
        }
    }
}
