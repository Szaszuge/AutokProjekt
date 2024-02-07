using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoberlesOKM_CsA
{
    class Auto
    {
        public static string CSVHead = "rendszam;tipus;modell;gyarto;kilometer";

        public string rendszam;
        public string tipus;
        public string modell;
        public string gyarto;
        public int kilometer;

        public Auto(string s)
        {
            string[] split = s.Split(';');

            this.rendszam  = split[0];
            this.tipus     = split[1];
            this.modell    = split[2];
            this.gyarto    = split[3];
            this.kilometer = Convert.ToInt32(split[4]);
        }

        public Auto(params string[] obj)
        {
            this.rendszam = obj[0];
            this.tipus = obj[1];
            this.modell = obj[2];
            this.gyarto = obj[3];
            this.kilometer = Convert.ToInt32(obj[4]);
        }

        public List<string> toStringList()
        {
            return new List<string>
            {
                this.rendszam,
                this.tipus,
                this.modell,
                this.gyarto,
                this.kilometer.ToString(),
            };
        }

        public override string ToString()
        {
            return $"{this.rendszam};{this.tipus};{this.modell};{this.gyarto};{this.kilometer}";
        }

        public static List<Auto> FromCSV(List<string> input)
        {
            input.RemoveAt(0);

            return input.Select(x => new Auto(x)).ToList();
        }

        public static List<string> ToCSV(List<Auto> input)
        {
            List<string> output = new List<string> {
                CSVHead
            };
            output.AddRange(input.Select(x => x.ToString()));

            return output;
        }
    }
}
