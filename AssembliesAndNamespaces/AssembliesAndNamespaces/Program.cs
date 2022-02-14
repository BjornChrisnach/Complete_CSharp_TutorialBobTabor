using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "A class is the most powerful data type in C#. Like a structure, " +
            //"a class defines the data and behavior of the data type. ";

            //File.WriteAllText(@"C:\Users\Gebruiker\source\repos\Youtube" + 
            //    @"\CompleteTutorialBobTabor\AssembliesAndNamespaces" + 
            //    @"\AssembliesAndNamespaces\bin\Debug\net5.0\WriteText.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("https://docs.microsoft.com");

            Console.WriteLine(reply);

            File.WriteAllText(@"C:\Users\Gebruiker\source\repos\Youtube" +
@"\CompleteTutorialBobTabor\AssembliesAndNamespaces" +
@"\AssembliesAndNamespaces\bin\Debug\net5.0\WriteText.txt", reply);

            File.WriteAllText(@"C:\Users\Gebruiker\source\repos\Youtube" +
        @"\CompleteTutorialBobTabor\AssembliesAndNamespaces" +
        @"\AssembliesAndNamespaces\bin\Debug\net5.0\WriteText.html", reply);

            // Example like in the new docs.microsoft.com, with a WriteAllText class file
            //_ = WriteAllText.ExampleAsync();

            // Self try, to make sure the string is complete before writing to a file,
            // with an async Task, but in this case not realy necessary 
            //Uri address = new("https://docs.microsoft.com");

            //Task<string> taskReply = GetDownloadString(address);

            //Console.WriteLine(taskReply.Result);

            //WriteToFile(taskReply.Result);

            // if you set the cmd window to close on it's own after debugging then
            // you need this line, i use the close after pressing a key function
            // Console.ReadLine();
        }

        //    public static async Task<string> GetDownloadString(Uri address)
        //    {
        //        WebClient client = new WebClient();

        //        string reply = "";

        //        await Task.Run(() => reply = client.DownloadString(address));

        //        return reply;
        //    }

        //    public static void WriteToFile(string text)
        //    {
        //        File.WriteAllText(@"C:\Users\Gebruiker\source\repos\Youtube" +
        //@"\CompleteTutorialBobTabor\AssembliesAndNamespaces" +
        //@"\AssembliesAndNamespaces\bin\Debug\net5.0\WriteText.html", text);
        //    }

    }
}
