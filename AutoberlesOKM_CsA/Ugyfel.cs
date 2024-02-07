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

        public string szemelyi;
        public string nev;
        public string lakcim;

        public Ugyfel(string s)
        {
            string[] split = s.Split(';');

            this.szemelyi = split[0];
            this.nev      = split[1];
            this.lakcim   = split[2];
        }

        public Ugyfel(params string[] obj)
        {
            this.szemelyi = obj[0];
            this.nev = obj[1];
            this.lakcim = obj[2];
        }

        public List<string> toStringList()
        {
            return new List<string>
            {
                this.szemelyi,
                this.nev,
                this.lakcim,
            };
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
