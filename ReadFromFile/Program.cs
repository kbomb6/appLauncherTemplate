using System;
using System.IO;
using System.Diagnostics;

namespace ReadFromFile
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            var yourFile = File.ReadAllLines("fileNameHere");
            foreach (string line in yourFile)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Would you like to run the Program? Press y to open it or n to exit the program");
            var userInput = Console.ReadKey();


            if (userInput.KeyChar == 'y')
            {
                ReadFile readFile = new ReadFile();
                readFile.OpenApplication();
            }
        }

        public void OpenApplication()
        {
            Process.Start("ApplicationPathHere");
        }
    }
}
