//using System.Collections.Generic;
//using System.IO;
//namespace Test
//{
//    public class General
//    {
//        public List<string> loadCsvFile(string filePath)
//        {
//            var reader = new StreamReader(File.OpenRead(filePath));
//            List<string> searchList = new List<string>();
//            while (!reader.EndOfStream)
//            {
//                var line = reader.ReadLine();
//                searchList.Add(line);
//            }
//            return searchList;
//        }
//    }

//    public class test
//    {
//        public static void Main()
//        {


//            var filepath = Path.GetDirectoryName(@"C:\\Users\\bhagyeshc\\Downloads\\csv\\");
//            General gen = new General();
//            gen.loadCsvFile(filepath);

//        }
//    }
//}