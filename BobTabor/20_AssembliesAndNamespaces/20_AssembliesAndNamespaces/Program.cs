using System;
using System.IO;
using System.Net;

namespace _20_AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "We want to write this to our file";

            File.WriteAllText(@"C:\Lesson17\WriteText.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}
