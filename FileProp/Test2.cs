using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileProp
{
  class FileInfo
  {
    static void prop()
    {

      string path = @"C:\Users\Miguel\Desktop\Importer\Importer";
      string[] entries = Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories);
      string delimiter = ", ";


      DateTime creationTime = File.GetCreationTime(@"C:\Users\Miguel\Desktop\Importer\Importer");
      DateTime lastWriteTime = File.GetLastWriteTime(@"C:\Users\Miguel\Desktop\Importer\Importer");
      DateTime lastAccessTime = File.GetLastAccessTime(@"C:\Users\Miguel\Desktop\Importer\Importer");

      foreach (string f in entries)
      {
        string createtext = creationTime + delimiter + lastWriteTime + delimiter + lastAccessTime + delimiter + Environment.NewLine;
        File.WriteAllText(path, createtext);
      }

    }
  }
}
