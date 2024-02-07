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

        private List<TextBox> autokTextBoxLista;
        private List<TextBox> ugyfelekTextBoxLista;
        private List<TextBox> berlesekTextBoxLista;

        private readonly string autokCSV       = "autok.csv";
        private readonly string ugyfelekCSV    = "ugyfelek.csv";
        private readonly string berbeadasokCSV = "berbeadasok.csv";

        private void Recover()
        {
            this.berbeadasok = Berbeadas.FromCSV(
                FileIO.tryReadCSV(
                    berbeadasokCSV,
                    new List<string> { Berbeadas.CSVHead }
                    )
                );

            this.autok = Auto.FromCSV(
                FileIO.tryReadCSV(
                    autokCSV,
                    new List<string> { Auto.CSVHead }
                    )
                );

            this.ugyfelek = Ugyfel.FromCSV(
                FileIO.tryReadCSV(
                    ugyfelekCSV,
                    new List<string> { Ugyfel.CSVHead }
                    )
                );
        }

        private void Save()
        {
            FileIO.writeFile(berbeadasokCSV, Berbeadas.ToCSV(this.berbeadasok));
            FileIO.writeFile(autokCSV, Auto.ToCSV(this.autok));
            FileIO.writeFile(ugyfelekCSV, Ugyfel.ToCSV(this.ugyfelek));
        }

        private void getTextBoxes()
        {
            autokTextBoxLista = new List<TextBox> {
                autokRendszamTBOX,
                autokTipusTBOX,
                autokGyartoTBOX,
                autokModellTBOX,
                autoKmTBOX,
            };

            ugyfelekTextBoxLista = new List<TextBox> {
                ugyfelekSzemelyiTBOX,
                ugyfelekNevTBOX,
                ugyfelekLakcimTBOX,
            };

            berlesekTextBoxLista = new List<TextBox> {
                berlesekAutoTBOX,
                berlesekUgyfelTBOX,
                berlesekElvitelKmphTBOX,
                berlesekElvitelDatumTBOX,
                berlesekVisszahozasKmphTBOX,
                berlesekVisszahozasDatumTBOX,
                berlesekOsszegTBOX,
            };
        }

        public Form1()
        {
            InitializeComponent();
            Recover();
            getTextBoxes();

            refreshGrid(autokGrid,    autok.Select(x => x.toStringList()).ToList());
            refreshGrid(ugyfelekGrid, ugyfelek.Select(x => x.toStringList()).ToList());
            refreshGrid(berlesekGrid, berbeadasok.Select(x => x.toStringList()).ToList());
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

        private string[] getStrings(List<TextBox> l)
        {
            return l.Select(x => x.Text).ToArray();
        }

        private void modifyGrid(DataGridView grid, List<TextBox> textBoxes)
        {
            grid.SelectedRows[0].SetValues(textBoxes.Select(x => x.Text).ToArray());
        }

        private void removeFromGrid(DataGridView grid)
        {
            grid.Rows.RemoveAt(grid.SelectedRows[0].Index);
        }

        private void refreshGrid(DataGridView grid, List<List<string>> l)
        {
            grid.Rows.Clear();

            foreach (List<string> sl in l) {
                grid.Rows.Add(sl.ToArray());
            }
        }

        /**
                              ___  __       
                     /\  |  |  |  /  \ |__/ 
                    /~~\ \__/  |  \__/ |  \ 
         */
        private void autokFelveszBTN_Click(object sender, EventArgs e)
        {
            autok.Add(new Auto(getStrings(autokTextBoxLista)));
            refreshGrid(autokGrid, autok.Select(x => x.toStringList()).ToList());
        }

        private void autokModositBTN_Click(object sender, EventArgs e)
        {
            modifyGrid(autokGrid, autokTextBoxLista);
        }

        private void autokTorolBTN_Click(object sender, EventArgs e)
        {
            removeFromGrid(autokGrid);
            autok.RemoveAt(autokGrid.SelectedRows[0].Index);
        }

        /**
                          __       ___  ___       ___      
                    |  | / _` \ / |__  |__  |    |__  |__/ 
                    \__/ \__>  |  |    |___ |___ |___ |  \ 
         */
        private void ugyfelekFelveszBTN_Click(object sender, EventArgs e)
        {
            ugyfelek.Add(new Ugyfel(getStrings(ugyfelekTextBoxLista)));
            refreshGrid(ugyfelekGrid, ugyfelek.Select(x => x.toStringList()).ToList());
        }

        private void ugyfelekModositBTN_Click(object sender, EventArgs e)
        {
            modifyGrid(ugyfelekGrid, ugyfelekTextBoxLista);
        }

        private void ugyfelekTorolBTN_Click(object sender, EventArgs e)
        {
            removeFromGrid(ugyfelekGrid);
            ugyfelek.RemoveAt(ugyfelekGrid.SelectedRows[0].Index);
        }

        /*
                     __   ___  __        ___  __   ___      
                    |__) |__  |__) |    |__  /__` |__  |__/ 
                    |__) |___ |  \ |___ |___ .__/ |___ |  \ 
         */
        private void berlesekFelveszBtn_Click(object sender, EventArgs e)
        {
            berbeadasok.Add(new Berbeadas(getStrings(berlesekTextBoxLista)));
            refreshGrid(berlesekGrid, berbeadasok.Select(x => x.toStringList()).ToList());
        }

        private void berlesekModositBTN_Click(object sender, EventArgs e)
        {
            modifyGrid(berlesekGrid, berlesekTextBoxLista);
        }

        private void berlesekTorolBTN_Click(object sender, EventArgs e)
        {
            removeFromGrid(berlesekGrid);
            berbeadasok.RemoveAt(berlesekGrid.SelectedRows[0].Index);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Save();
        }

        private void statButton_Click(object sender, EventArgs e)
        {
            // osszbevetel
            // legtobbet berbeadott auto
            // legtobbet kolcsonzo ugyfel
            // atlag berbeadas naponta
            int osszesOsszeg = 0;
            Dictionary<string, int> autoStat = new Dictionary<string, int>();
            Dictionary<string, int> ugyfelStat = new Dictionary<string, int>();

            berbeadasok.ForEach(x =>
            {
                osszesOsszeg += x.osszeg;

                int c;

                if (autoStat.TryGetValue(x.auto, out c))
                {
                    autoStat[x.auto]++;
                } else
                {
                    autoStat.Add(x.auto, 1);
                }

                if (ugyfelStat.TryGetValue(x.ugyfel, out c))
                {
                    ugyfelStat[x.ugyfel]++;
                }
                else
                {
                    ugyfelStat.Add(x.ugyfel, 1);
                }
            });

            KeyValuePair<string, int> legtobbetBerbeadottAuto = new KeyValuePair<string, int>("semmi", 0);
            KeyValuePair<string, int> legtobbetKolcsonzoUgyfel = new KeyValuePair<string, int>("senki", 0);

            foreach (KeyValuePair<string, int> kv in autoStat)
            {
                if (kv.Value > legtobbetBerbeadottAuto.Value)
                {
                    legtobbetBerbeadottAuto = kv;
                }
            }

            foreach (KeyValuePair<string, int> kv in ugyfelStat)
            {
                if (kv.Value > legtobbetKolcsonzoUgyfel.Value)
                {
                    legtobbetKolcsonzoUgyfel = kv;
                }
            }

            MessageBox.Show(
                $"Összbevétel: {osszesOsszeg} Ft\n" +
                $"A legtöbbet bérbeadott autó az a {legtobbetBerbeadottAuto.Key} és összesen {legtobbetBerbeadottAuto.Value}x lett bérbe adva.\n" +
                $"A legtöbbet kölcsönző ügyfél az {legtobbetKolcsonzoUgyfel.Key} és összesen {legtobbetKolcsonzoUgyfel.Value}x kölcsönzött ki autót."
                );
        }
    }
}
