using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoberlesOKM_CsA
{
    class Berbeadas
    {
        string auto;
        string ugyfel;
        int elvitelkm;
        int visszahozaskm;
        string elviteldatum;
        string visszahozasdatum;
        int osszeg;

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
            List<string> output = new List<string>();
            output.Add("auto;ugyfel;elvitelkm;visszahozaskm;elviteldatum;visszahozasdatum;osszeg");
            output.AddRange(input.Select(x => x.ToString()));

            return output;
        }
    }
}
