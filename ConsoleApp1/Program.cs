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
        public delegate void MyDelegate();

        public static void Main(String[] args)
        {
            MyDelegate myDelegate = Method1;
            myDelegate();
        }


        public static void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }

       

    

    
}
}

