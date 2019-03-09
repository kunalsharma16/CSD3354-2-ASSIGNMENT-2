using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//kunal sharma C0727250
// Sohit sharma C0730478
namespace DelegatesAndEvents
{
    public class DelegateExercises
    {
        public delegate void MyDelegate(int value);

        public static void Main(String[] args)
        {
            MyDelegate myDelegate = Method1;
            myDelegate+=Method3;
            myDelegate(50);
        }

        public static void Method1(int num1)
        {
            Console.WriteLine(num1 * 2);
        }

        public static void Method3(int num2)
        {
            Console.WriteLine(num2 * 10);
        }
        public static void Method2(int x)
        {
            Console.WriteLine("Method2");
            Console.WriteLine("Number is "+x);
            Console.ReadLine();
        }

        

    
}
}

