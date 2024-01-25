using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoberlesOKM_CsA
{
    class FileIO
    {
        public static List<string> readFile(string filename)
        {
            List<string> lines = new List<string>();

            try
            {
                StreamReader reader = new StreamReader(filename, Encoding.UTF8);

                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    lines.Add(reader.ReadLine());
                }

                reader.Close();
            }
            catch { }

            return lines;
        }

        public static void writeFile(string filename, List<string> data)
        {
            try
            {
                StreamWriter writer = new StreamWriter(filename);

                writer.WriteLine("név;születési_dátum;nemzetiség;rajtszám");

                foreach (string line in data)
                {
                    writer.WriteLine(line);
                }

                writer.Close();
            }
            catch { }
        }
    }
}
