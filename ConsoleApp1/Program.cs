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
                return intMethod1 * 2;

            }

            int method2(int intmethod1)
            {
                return intmethod1 * 10;
            }

            public void Method4(MyDelegate myDelegate)
            {
                int result = myDelegate(10);
                Console.WriteLine(result);

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


