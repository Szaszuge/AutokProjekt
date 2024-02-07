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
        /*
         * Megprobalja readelni a CSV filet, ha nem letezik a file akkor elkesziti es a def parameternek megadott erteket adja vissza
         * 
         * (ha letezik nyilvan bereadeli a filet es visszaadja a contentet)
         */
        public static List<string> tryReadCSV(string filename, List<string> def)
        {
            if (!File.Exists(filename))
            {
                writeFile(filename, def);
                return def;
            }

            return readFile(filename);
        }

        public static List<string> readFile(string filename)
        {
            List<string> lines = new List<string>();

            try
            {
                StreamReader reader = new StreamReader(filename, Encoding.UTF8);

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
