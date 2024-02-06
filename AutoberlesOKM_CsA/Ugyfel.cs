using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoberlesOKM_CsA
{
    class Ugyfel
    {
        public static string CSVHead = "szemelyi;nev;lakcim";

        string szemelyi;
        string nev;
        string lakcim;

        public Ugyfel(string s)
        {
            string[] split = s.Split(';');

            this.szemelyi = split[0];
            this.nev      = split[1];
            this.lakcim   = split[2];
        }

        public override string ToString()
        {
            return $"{this.szemelyi};{this.nev};{this.lakcim}";
        }

        public static List<Ugyfel> FromCSV(List<string> input)
        {
            input.RemoveAt(0);

            return input.Select(x => new Ugyfel(x)).ToList();
        }

        public static List<string> ToCSV(List<Ugyfel> input)
        {
            List<string> output = new List<string> { 
                CSVHead
            };
            output.AddRange(input.Select(x => x.ToString()));

            return output;
        }
    }
}
