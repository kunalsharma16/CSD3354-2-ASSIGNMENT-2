using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DelegatesAndEvents
{
    public class Program

    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.method3();
            Console.ReadLine();
        }
        
        public class DelegateExercises
        {
            public delegate int MyDelegate(int value);
            int Method1(int intMethod1)

            {
                return intMethod1 * 4;

            }

            int method2(int intmethod1)
            {
                return intmethod1 * 20;
            }

            public void Method4(MyDelegate myDelegate)
            {
                for (int i = 1; i <= 5; i++)
                    Console.WriteLine(myDelegate(i) + " ");

            }

            public void method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                Method4(myDelegate);
                myDelegate = new MyDelegate(method2);
                Method4(myDelegate);
            }











        }
    }
}


