using Itec_Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace Itec_Project
{
    public static class Helper
    {
        public static string AttachmentsFolder = @"Attachments\";
        private const string MatchEmailPattern =
           @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
    + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
    + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
    + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
        public static bool CheckEmailAddress(string Email)
        {
            if (Email != null && Email != string.Empty)
                return System.Text.RegularExpressions.Regex.IsMatch(Email, MatchEmailPattern);
            return false;
        }

        public static void readXML(string path)
        {
            XmlTextReader theFile = new XmlTextReader(path);
            while (theFile.Read())
            {
                switch (theFile.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        while (theFile.MoveToNextAttribute()) // Read the attributes.
                        {
                            System.Diagnostics.Debug.WriteLine("atr " + theFile.Value + " atr");
                        }
                        System.Diagnostics.Debug.WriteLine("<" + theFile.Name + ">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        System.Diagnostics.Debug.WriteLine(theFile.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        System.Diagnostics.Debug.WriteLine("</" + theFile.Name + ">");
                        break;
                }
            }
            theFile = null;
        }
        public static void WriteToDiskAs(string input, string output)
        {
            try
            {
                output = AppDomain.CurrentDomain.BaseDirectory + output;
                File.Copy(input, output, File.Exists(output));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        public static void DeleteAttachmentFromDisk(Attachment atachment)
        {
            if (File.Exists(AttachmentsFolder + atachment.FullFileName))
                File.Delete(AttachmentsFolder + atachment.FullFileName);
        }
        public static string FileBase64(string path)
        {
            try
            {
                byte[] bytes = File.ReadAllBytes(path);
                string a = Convert.ToBase64String(bytes);
                return a;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return "";
        }

        public static string getRandomText(int length = 5)
        {
            System.Net.WebClient client = new System.Net.WebClient();
            string downloadedString = client.DownloadString(String.Format("http://www.lipsum.com/feed/xml?amount={0}&what=words&start=no", length));

            int nrOfChars = "<lipsum>".Length;
            int first = downloadedString.IndexOf("<lipsum>");
            int second = downloadedString.IndexOf("</lipsum>");
            string message = downloadedString.Substring(first + nrOfChars, second - first - nrOfChars);
            return message;
        }
    }
}