using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoberlesOKM_CsA
{
    class Berbeadas
    {
        public static string CSVHead = "auto;ugyfel;elvitelkm;visszahozaskm;elviteldatum;visszahozasdatum;osszeg";

        public string auto;
        public string ugyfel;
        public int elvitelkm;
        public int visszahozaskm;
        public string elviteldatum;
        public string visszahozasdatum;
        public int osszeg;

        public Berbeadas(string s)
        {
            string[] split = s.Split(';');

            this.auto             = split[0];
            this.ugyfel           = split[1];
            this.elvitelkm        = Convert.ToInt32(split[2]);
            this.visszahozaskm    = Convert.ToInt32(split[3]);
            this.elviteldatum     = split[4];
            this.visszahozasdatum = split[5];
            this.osszeg           = Convert.ToInt32(split[6]);
        }

        public Berbeadas(params string[] obj)
        {
            this.auto             = (string)obj[0];
            this.ugyfel           = (string)obj[1];
            this.elvitelkm        = Convert.ToInt32(obj[2]);
            this.visszahozaskm    = Convert.ToInt32(obj[3]);
            this.elviteldatum     = (string)obj[4];
            this.visszahozasdatum = (string)obj[5];
            this.osszeg           = Convert.ToInt32(obj[6]);
        }

        public List<string> toStringList()
        {
            return new List<string>
            {
                this.auto,
                this.ugyfel,
                this.elvitelkm.ToString(),
                this.visszahozaskm.ToString(),
                this.elviteldatum,
                this.visszahozasdatum,
                this.osszeg.ToString(),
            };
        }

        public override string ToString()
        {
            return $"{this.auto};{this.ugyfel};{this.elvitelkm};{this.visszahozaskm};{this.elviteldatum};{this.visszahozasdatum};{osszeg}";
        }

        public static List<Berbeadas> FromCSV(List<string> input)
        {
            input.RemoveAt(0);

            return input.Select(x => new Berbeadas(x)).ToList();
        }

        public static List<string> ToCSV(List<Berbeadas> input)
        {
            List<string> output = new List<string>
            {
                CSVHead
            };
            output.AddRange(input.Select(x => x.ToString()));

            return output;
        }
    }
}
