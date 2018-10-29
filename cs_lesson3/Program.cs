using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //布尔运算和位运算 (C#_入门经典第4版_4.1.2)

            Console.WriteLine("Enter an integer:");
            int myInt = Convert.ToInt32(Console.ReadLine());    //输入
            Console.WriteLine("Integer less than 10 ? {0}", myInt < 10);    //布尔运算
            Console.WriteLine("Integer between 0 and 5 ? {0}",
                (0 <= myInt) && (myInt <= 5));
            Console.WriteLine("Bitwise AND of Integer and 10 = {0}",   //位AND运算
                myInt & 10);
            Console.ReadKey(); 
        }
    }
}
