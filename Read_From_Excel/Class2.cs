using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_From_Excel
{
    public class Class2
    {
        public static void Main()
        {
            // var str = "abcd@acsi.eu";
            // var values = str.Split('@');
            var domain = "acsi.eu";
            string str = "jverrezen@acsi.eu";
            if(str.Contains("@acsi.eu"))
            {
                Console.WriteLine("true");
                Console.ReadLine();
            }
            string result = str.Substring(str.IndexOf('@') + 1);
            //string ext = str.Substring(0, str.LastIndexOf("@") + 0);
            Console.WriteLine(result);
            Console.ReadLine();
            if (string.Equals(domain, result))
            {
                Console.WriteLine("Equal");
                Console.ReadLine();
            }
            
        }
    }
}
