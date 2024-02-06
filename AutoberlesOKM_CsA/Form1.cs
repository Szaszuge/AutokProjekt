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

        private void addToGrid(DataGridView grid, List<TextBox> textBoxes)
        {
            List<string> l = new List<string>();
            textBoxes.ForEach(tbox =>
            {
                l.Add(tbox.Text);
            });

            grid.Rows.Add(l.ToArray());
        }

        /**
                              ___  __       
                     /\  |  |  |  /  \ |__/ 
                    /~~\ \__/  |  \__/ |  \ 
         */
        private void autokFelveszBTN_Click(object sender, EventArgs e)
        {
            addToGrid(autokGrid, new List<TextBox> {
                autokRendszamTBOX,
                autokTipusTBOX,
                autokGyartoTBOX,
                autokModellTBOX,
                autoKmTBOX,
            });
        }

        /**
                          __       ___  ___       ___      
                    |  | / _` \ / |__  |__  |    |__  |__/ 
                    \__/ \__>  |  |    |___ |___ |___ |  \ 
         */
        private void ugyfelekFelveszBTN_Click(object sender, EventArgs e)
        {
            addToGrid(ugyfelekGrid, new List<TextBox> {
                ugyfelekSzemelyiTBOX,
                ugyfelekNevTBOX,
                ugyfelekLakcimTBOX,
            });
        }

        /*
                     __   ___  __        ___  __   ___      
                    |__) |__  |__) |    |__  /__` |__  |__/ 
                    |__) |___ |  \ |___ |___ .__/ |___ |  \ 
         */
        private void berlesekFelveszBtn_Click(object sender, EventArgs e)
        {
            addToGrid(berlesekGrid, new List<TextBox> {
                berlesekAutoTBOX,
                berlesekUgyfelTBOX,
                berlesekElvitelKmphTBOX,
                berlesekElvitelDatumTBOX,
                berlesekVisszahozasKmphTBOX,
                berlesekVisszahozasDatumTBOX,
                berlesekOsszegTBOX,
            });
        }
    }
}
