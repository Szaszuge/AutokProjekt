using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoberlesOKM_CsA
{
    public partial class Form1 : Form
    {
        private List<Berbeadas> berbeadasok;
        private List<Auto> autok;
        private List<Ugyfel> ugyfelek;

        private void Recover()
        {
            this.berbeadasok = Berbeadas.FromCSV(
                FileIO.tryReadCSV(
                    "berbeadasok.csv",
                    new List<string> { Berbeadas.CSVHead }
                    )
                );

            this.autok = Auto.FromCSV(
                FileIO.tryReadCSV(
                    "autok.csv",
                    new List<string> { Auto.CSVHead }
                    )
                );

            this.ugyfelek = Ugyfel.FromCSV(
                FileIO.tryReadCSV(
                    "ugyfelek.csv",
                    new List<string> { Ugyfel.CSVHead }
                    )
                );
        }

        private void Save()
        {

        }

        public Form1()
        {
            InitializeComponent();
            Recover();
        }
    }
}
