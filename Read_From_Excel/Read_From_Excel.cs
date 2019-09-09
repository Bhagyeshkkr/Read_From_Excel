//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Reflection.Emit;
//using System.Security.Cryptography.X509Certificates;
//using System.Text.RegularExpressions;
//using System.Xml;

//namespace Test
//{
//    public class test
//    {
//        public static void Main()
//        {                             
//            string inputString = @"< table >< tr >< td colspan = '2' style = 'border-top: 1px solid black'; >< strong > Gebruikersgegevens </ strong ></ td ></ tr >< tr >< td > userid:</ td >< td > 165191 </ td ></ tr >< tr >< td > username:</ td >< td > cp100627 - 01 </ td ></ tr >< tr >< td > password:</ td >< td > 87bcJ6zE </ td ></ tr >< tr >< td > password md5:</ td >< td > 70b8cd7d918f94febf66c31201695684 </ td ></ tr >< tr >< td > password md5 tbl:</ td >< td > 70b8cd7d918f94febf66c31201695684 </ td ></ tr >< tr >< td > actief:</ td >< td > ja </ td ></ tr >< tr >< td colspan = 2 >< strong > (Actieve)profielen </ strong ></ td ></ tr ></ table >< br />
//                < form method = post >
//                 Email / Gebruikersnaam: < input type = 'text' name = email size = 20 />
//                < input type = submit value = 'zoeken' />
//                </ form >";

//            string strWithoutTags = Regex.Replace(inputString, "<[^>]*>", "\n");
//            string pattern = "\n\\s+";
//            strWithoutTags =  Regex.Replace(strWithoutTags, pattern, "");

//            int startIndex = strWithoutTags.IndexOf("password:");
//            int endIndex = strWithoutTags.LastIndexOf("password md5:");
//            string result = string.Empty;
//            if (startIndex > 0 && endIndex > 0)
//            {
//                result = strWithoutTags.Substring(startIndex, endIndex - startIndex);
//                string[] passwordStrings = result.Split(':');
//                result = Regex.Replace(passwordStrings[1], " ", "");
//                Console.Write(result);
//            }

//            //return result;

//            Console.ReadLine();
//        }
        
//    }
//}
