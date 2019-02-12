using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            String filename;
            String content;
            Console.Out.WriteLine("Document");
            Console.Out.Write("Name of document: ");
            filename = Console.ReadLine();
            Console.Out.Write("Content: ");
            content = Console.ReadLine();
            filename = filename + ".txt";

            try
            {
                StreamWriter streamWriter = new StreamWriter(filename);
                    streamWriter.WriteLine(content);
                    streamWriter.Close();              
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("{0} was successfully saved. The document contains {1} characters.", filename, content.Length);
            }

        }
    }
}
