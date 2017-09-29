using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roma1
{

    class SuperList<T> : List<T> where T : class
    {
     
        public SuperList()
        {
  
        }
         
        public static SuperList<T> operator +(SuperList<T> a, T b)
        {
            SuperList<T> m;
               if (a.Count >= 3)
                throw new IndexOutOfRangeException();

          
             a.Add(b);
            m = a;
            return m;

        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            string a = "Oleg";
            SuperList<string> obj = new SuperList<string>();
            SuperList<string> obj1 = new SuperList<string>();
            try
            {
                for (int i = 0; i <4; i++)
                {
                    obj = obj + a;
                }
                
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
