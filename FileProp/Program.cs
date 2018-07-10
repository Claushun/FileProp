using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileProp
{
  class Program
  {
    static void Main(string[] args)
    {


      string path = @"C:\Users\Miguel\Desktop\MyTest.csv";

      // Set the variable "delimiter" to ", ".
      string delimiter = ", ";

      DateTime creationTime = File.GetCreationTime(@"C:\Users\Miguel\Desktop\Importer\Importer");
      DateTime lastWriteTime = File.GetLastWriteTime(@"C:\Users\Miguel\Desktop\Importer\Importer");
      DateTime lastAccessTime = File.GetLastAccessTime(@"C:\Users\Miguel\Desktop\Importer\Importer");

      string[] array = Directory.GetFiles(@"C:\Users\Miguel\Desktop\Importer\Importer"); // store files within a directory into a list
                                                                                         //string[] entries = Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories);

      if (!File.Exists(path))
      {
        string createtext = creationTime + delimiter + lastWriteTime + delimiter + lastAccessTime + delimiter + Environment.NewLine;
        File.WriteAllText(path, createtext);
      }


      // Keep the console window open in debug mode.
      string readtext = File.ReadAllText(path);

      Console.WriteLine("Press any key to exit.");
      Console.ReadKey();
    }
  }
}
