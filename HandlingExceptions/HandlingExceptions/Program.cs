using System;
using System.IO;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string content = File.ReadAllText(@"C:\Users\Gebruiker\source\repos\Youtube" +
            //    @"\CompleteTutorialBobTabor\HandlingExceptions\HandlingExceptions\bin\Debug" +
            //    @"\net5.0\Example.txt");

            try
            {
            // Error, System.IO.FileNotFoundException: 'Could not find file
            string content = File.ReadAllText(@"C:\Users\Gebruiker\OneDrive\Documenten" + 
                @"\HandlingExceptionsDirectory\Exampl.txt");
            Console.WriteLine(content);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly: Example.txt");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure the directory 'C:\Users\Gebruiker\OneDrive" + 
                    @"\Documenten\HandlingExceptionsDirectory' exists.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Code to finalize
                // Setting objects to null
                // Closing database connections
                Console.WriteLine("Closing application now...");
            }

            Console.ReadLine();

        }
    }
}
