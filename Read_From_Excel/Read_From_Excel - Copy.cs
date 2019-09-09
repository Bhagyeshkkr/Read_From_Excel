//using System;
//using System.Collections.Generic;
//using System.IO;
//namespace Test
//{  
//    public class test
//    {
//        public static void Main()
//        {

//            using (var reader = new StreamReader(@"C:\\Users\\bhagyeshc\\Desktop\\test1.html"))
//            {
//                List<string> listA = new List<string>();
//                List<string> listB = new List<string>();
//                while (!reader.EndOfStream)
//                {
//                    var line = reader.ReadLine();
//                    var values = line.Split(';');

//                    listA.Add(values[0]);
//                  //  listB.Add(values[1]);
//                }
//                listA.ForEach(Console.WriteLine);
//            }

//        }
//    }
//}