//using System;//using System.Collections.Generic;//using System.Linq;//using System.Text;//using System.IO;//using System.Text.RegularExpressions;//using System.Threading.Tasks;//namespace Read_Password_From_HTML//{//    class Program//    {//        private const string InputFileName = "F:\\ACSI\\Password.html";//        private const string OutputFileName = "F:\\ACSI\\PasswordDecrypted.html";//        private const string Charset = "windows-1251";//        static void Main(string[] args)//        {//            if (!File.Exists(InputFileName))//            {//                Console.WriteLine(//                    "File " + InputFileName + " not found.");//                return;//            }//            StreamReader reader = null;//            StreamWriter writer = null;//            try//            {//                Encoding encoding = Encoding.GetEncoding(Charset);//                reader = new StreamReader(InputFileName, encoding);//                writer = new StreamWriter(OutputFileName, false,//                    encoding);//                string line;//                string allText = string.Empty;//                while ((line = reader.ReadLine()) != null)//                {//                    line = RemoveAllTags(line);//                    line = RemoveDoubleNewLines(line);//                    line = TrimNewLines(line);//                    allText = allText + line;//                    if (!string.IsNullOrEmpty(line))//                    {//                        writer.WriteLine(line);//                    }//                }//                string strWithoutTags = allText = Regex.Replace(allText, "\n", " ");
//                //Console.Write(allText);

//                int startindex = allText.IndexOf("password:");//                int Endindex = allText.IndexOf("password md5");
//                //Console.Write(startindex);
//                //Console.Write(Endindex);

//                string outputstring = allText.Substring(startindex, Endindex - startindex);//                string[] pass = outputstring.Split(':');//                outputstring = Regex.Replace(pass[1], " ", "");//                Console.Write(outputstring);//                Task t = new Task(DownloadPageAsync);//                t.Start();//                Console.WriteLine("Downloading page...");//                Console.ReadLine();//                string inputString = "";//                string strWithoutTags1 =//                Regex.Replace(inputString, "<[^>]*>", "\n");

//                //Console.Write(allText);
//                Console.ReadLine();//            }//            catch (IOException)//            {//                Console.WriteLine(//                    "Can not read file " + InputFileName + ".");//            }//            finally//            {//                if (reader != null)//                {//                    reader.Close();//                }//                if (writer != null)//                {//                    writer.Close();//                }//            }//        }









//        /// <summary>
//        /// Replaces every tag with new line
//        /// </summary>
//        private static string RemoveAllTags(string str)//        {//            string strWithoutTags =//                Regex.Replace(str, "<[^>]*>", "\n");//            return strWithoutTags;//        }









//        /// <summary>
//        /// Replaces sequence of new lines with only one new line
//        /// </summary>
//        private static string RemoveDoubleNewLines(string str)//        {//            string pattern = "\n\\s+";//            return Regex.Replace(str, pattern, "\n");//        }









//        /// <summary>
//        /// Removes new lines from start and end of string
//        /// </summary>
//        private static string TrimNewLines(string str)//        {//            int start = 0;//            while (start < str.Length && str[start] == '\n')//            {//                start++;//            }//            int end = str.Length - 1;//            while (end >= 0 && str[end] == '\n')//            {//                end--;//            }//            if (start > end)//            {//                return string.Empty;//            }//            string trimmed = str.Substring(start, end - start + 1);//            return trimmed;//        }//    }//}