
namespace AutoberlesOKM_CsA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.autokGrid = new System.Windows.Forms.DataGridView();
            this.rendszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.km = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autokFelveszBTN = new System.Windows.Forms.Button();
            this.ugyfelekGrid = new System.Windows.Forms.DataGridView();
            this.szemelyiSzam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lakcim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.autokPage = new System.Windows.Forms.TabPage();
            this.autoKmTBOX = new System.Windows.Forms.TextBox();
            this.autokModellTBOX = new System.Windows.Forms.TextBox();
            this.autokGyartoTBOX = new System.Windows.Forms.TextBox();
            this.autokTipusTBOX = new System.Windows.Forms.TextBox();
            this.autokRendszamTBOX = new System.Windows.Forms.TextBox();
            this.autokModositBTN = new System.Windows.Forms.Button();
            this.autokTorolBTN = new System.Windows.Forms.Button();
            this.ugyfelekPage = new System.Windows.Forms.TabPage();
            this.ugyfelekLakcimTBOX = new System.Windows.Forms.TextBox();
            this.ugyfelekNevTBOX = new System.Windows.Forms.TextBox();
            this.ugyfelekSzemelyiTBOX = new System.Windows.Forms.TextBox();
            this.ugyfelekModositBTN = new System.Windows.Forms.Button();
            this.ugyfelekTorolBTN = new System.Windows.Forms.Button();
            this.ugyfelekFelveszBTN = new System.Windows.Forms.Button();
            this.berlesekPage = new System.Windows.Forms.TabPage();
            this.berlesekVisszahozasKmphTBOX = new System.Windows.Forms.TextBox();
            this.berlesekElvitelDatumTBOX = new System.Windows.Forms.TextBox();
            this.berlesekOsszegTBOX = new System.Windows.Forms.TextBox();
            this.berlesekVisszahozasDatumTBOX = new System.Windows.Forms.TextBox();
            this.berlesekElvitelKmphTBOX = new System.Windows.Forms.TextBox();
            this.berlesekUgyfelTBOX = new System.Windows.Forms.TextBox();
            this.berlesekAutoTBOX = new System.Windows.Forms.TextBox();
            this.berlesekModositBTN = new System.Windows.Forms.Button();
            this.berlesekTorolBTN = new System.Windows.Forms.Button();
            this.berlesekFelveszBtn = new System.Windows.Forms.Button();
            this.berlesekGrid = new System.Windows.Forms.DataGridView();
            this.auto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elvitelkmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visszahozaskmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elviteldatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visszahozdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autokGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelekGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.autokPage.SuspendLayout();
            this.ugyfelekPage.SuspendLayout();
            this.berlesekPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.berlesekGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // autokGrid
            // 
            this.autokGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autokGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rendszam,
            this.tipus,
            this.gyarto,
            this.modell,
            this.km});
            this.autokGrid.Location = new System.Drawing.Point(0, 0);
            this.autokGrid.MultiSelect = false;
            this.autokGrid.Name = "autokGrid";
            this.autokGrid.ReadOnly = true;
            this.autokGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.autokGrid.Size = new System.Drawing.Size(545, 540);
            this.autokGrid.TabIndex = 0;
            // 
            // rendszam
            // 
            this.rendszam.HeaderText = "Rendszám";
            this.rendszam.Name = "rendszam";
            this.rendszam.ReadOnly = true;
            // 
            // tipus
            // 
            this.tipus.HeaderText = "Típus";
            this.tipus.Name = "tipus";
            this.tipus.ReadOnly = true;
            // 
            // gyarto
            // 
            this.gyarto.HeaderText = "Gyártó";
            this.gyarto.Name = "gyarto";
            this.gyarto.ReadOnly = true;
            // 
            // modell
            // 
            this.modell.HeaderText = "Modell";
            this.modell.Name = "modell";
            this.modell.ReadOnly = true;
            // 
            // km
            // 
            this.km.HeaderText = "Km";
            this.km.Name = "km";
            this.km.ReadOnly = true;
            // 
            // autokFelveszBTN
            // 
            this.autokFelveszBTN.Location = new System.Drawing.Point(551, 6);
            this.autokFelveszBTN.Name = "autokFelveszBTN";
            this.autokFelveszBTN.Size = new System.Drawing.Size(246, 57);
            this.autokFelveszBTN.TabIndex = 2;
            this.autokFelveszBTN.Text = "Felvesz";
            this.autokFelveszBTN.UseVisualStyleBackColor = true;
            this.autokFelveszBTN.Click += new System.EventHandler(this.autokFelveszBTN_Click);
            // 
            // ugyfelekGrid
            // 
            this.ugyfelekGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ugyfelekGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ugyfelekGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.szemelyiSzam,
            this.nev,
            this.lakcim});
            this.ugyfelekGrid.Location = new System.Drawing.Point(0, 0);
            this.ugyfelekGrid.MultiSelect = false;
            this.ugyfelekGrid.Name = "ugyfelekGrid";
            this.ugyfelekGrid.ReadOnly = true;
            this.ugyfelekGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ugyfelekGrid.Size = new System.Drawing.Size(545, 540);
            this.ugyfelekGrid.TabIndex = 3;
            // 
            // szemelyiSzam
            // 
            this.szemelyiSzam.HeaderText = "Személyi";
            this.szemelyiSzam.Name = "szemelyiSzam";
            this.szemelyiSzam.ReadOnly = true;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // lakcim
            // 
            this.lakcim.HeaderText = "Lakcím";
            this.lakcim.Name = "lakcim";
            this.lakcim.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.autokPage);
            this.tabControl1.Controls.Add(this.ugyfelekPage);
            this.tabControl1.Controls.Add(this.berlesekPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 566);
            this.tabControl1.TabIndex = 4;
            // 
            // autokPage
            // 
            this.autokPage.Controls.Add(this.autoKmTBOX);
            this.autokPage.Controls.Add(this.autokModellTBOX);
            this.autokPage.Controls.Add(this.autokGyartoTBOX);
            this.autokPage.Controls.Add(this.autokTipusTBOX);
            this.autokPage.Controls.Add(this.autokRendszamTBOX);
            this.autokPage.Controls.Add(this.autokModositBTN);
            this.autokPage.Controls.Add(this.autokTorolBTN);
            this.autokPage.Controls.Add(this.autokGrid);
            this.autokPage.Controls.Add(this.autokFelveszBTN);
            this.autokPage.Location = new System.Drawing.Point(4, 22);
            this.autokPage.Name = "autokPage";
            this.autokPage.Padding = new System.Windows.Forms.Padding(3);
            this.autokPage.Size = new System.Drawing.Size(803, 540);
            this.autokPage.TabIndex = 0;
            this.autokPage.Text = "Autók";
            this.autokPage.UseVisualStyleBackColor = true;
            // 
            // autoKmTBOX
            // 
            this.autoKmTBOX.Location = new System.Drawing.Point(551, 299);
            this.autoKmTBOX.Name = "autoKmTBOX";
            this.autoKmTBOX.Size = new System.Drawing.Size(246, 20);
            this.autoKmTBOX.TabIndex = 9;
            // 
            // autokModellTBOX
            // 
            this.autokModellTBOX.Location = new System.Drawing.Point(551, 273);
            this.autokModellTBOX.Name = "autokModellTBOX";
            this.autokModellTBOX.Size = new System.Drawing.Size(246, 20);
            this.autokModellTBOX.TabIndex = 8;
            // 
            // autokGyartoTBOX
            // 
            this.autokGyartoTBOX.Location = new System.Drawing.Point(551, 247);
            this.autokGyartoTBOX.Name = "autokGyartoTBOX";
            this.autokGyartoTBOX.Size = new System.Drawing.Size(246, 20);
            this.autokGyartoTBOX.TabIndex = 7;
            // 
            // autokTipusTBOX
            // 
            this.autokTipusTBOX.Location = new System.Drawing.Point(551, 221);
            this.autokTipusTBOX.Name = "autokTipusTBOX";
            this.autokTipusTBOX.Size = new System.Drawing.Size(246, 20);
            this.autokTipusTBOX.TabIndex = 6;
            // 
            // autokRendszamTBOX
            // 
            this.autokRendszamTBOX.Location = new System.Drawing.Point(551, 195);
            this.autokRendszamTBOX.Name = "autokRendszamTBOX";
            this.autokRendszamTBOX.Size = new System.Drawing.Size(246, 20);
            this.autokRendszamTBOX.TabIndex = 5;
            // 
            // autokModositBTN
            // 
            this.autokModositBTN.Location = new System.Drawing.Point(551, 132);
            this.autokModositBTN.Name = "autokModositBTN";
            this.autokModositBTN.Size = new System.Drawing.Size(246, 57);
            this.autokModositBTN.TabIndex = 4;
            this.autokModositBTN.Text = "Módosít";
            this.autokModositBTN.UseVisualStyleBackColor = true;
            this.autokModositBTN.Click += new System.EventHandler(this.autokModositBTN_Click);
            // 
            // autokTorolBTN
            // 
            this.autokTorolBTN.Location = new System.Drawing.Point(551, 69);
            this.autokTorolBTN.Name = "autokTorolBTN";
            this.autokTorolBTN.Size = new System.Drawing.Size(246, 57);
            this.autokTorolBTN.TabIndex = 3;
            this.autokTorolBTN.Text = "Töröl";
            this.autokTorolBTN.UseVisualStyleBackColor = true;
            this.autokTorolBTN.Click += new System.EventHandler(this.autokTorolBTN_Click);
            // 
            // ugyfelekPage
            // 
            this.ugyfelekPage.Controls.Add(this.ugyfelekLakcimTBOX);
            this.ugyfelekPage.Controls.Add(this.ugyfelekNevTBOX);
            this.ugyfelekPage.Controls.Add(this.ugyfelekSzemelyiTBOX);
            this.ugyfelekPage.Controls.Add(this.ugyfelekModositBTN);
            this.ugyfelekPage.Controls.Add(this.ugyfelekTorolBTN);
            this.ugyfelekPage.Controls.Add(this.ugyfelekFelveszBTN);
            this.ugyfelekPage.Controls.Add(this.ugyfelekGrid);
            this.ugyfelekPage.Location = new System.Drawing.Point(4, 22);
            this.ugyfelekPage.Name = "ugyfelekPage";
            this.ugyfelekPage.Padding = new System.Windows.Forms.Padding(3);
            this.ugyfelekPage.Size = new System.Drawing.Size(803, 540);
            this.ugyfelekPage.TabIndex = 1;
            this.ugyfelekPage.Text = "Ügyfelek";
            this.ugyfelekPage.UseVisualStyleBackColor = true;
            // 
            // ugyfelekLakcimTBOX
            // 
            this.ugyfelekLakcimTBOX.Location = new System.Drawing.Point(551, 247);
            this.ugyfelekLakcimTBOX.Name = "ugyfelekLakcimTBOX";
            this.ugyfelekLakcimTBOX.Size = new System.Drawing.Size(246, 20);
            this.ugyfelekLakcimTBOX.TabIndex = 15;
            // 
            // ugyfelekNevTBOX
            // 
            this.ugyfelekNevTBOX.Location = new System.Drawing.Point(551, 221);
            this.ugyfelekNevTBOX.Name = "ugyfelekNevTBOX";
            this.ugyfelekNevTBOX.Size = new System.Drawing.Size(246, 20);
            this.ugyfelekNevTBOX.TabIndex = 14;
            // 
            // ugyfelekSzemelyiTBOX
            // 
            this.ugyfelekSzemelyiTBOX.Location = new System.Drawing.Point(551, 195);
            this.ugyfelekSzemelyiTBOX.Name = "ugyfelekSzemelyiTBOX";
            this.ugyfelekSzemelyiTBOX.Size = new System.Drawing.Size(246, 20);
            this.ugyfelekSzemelyiTBOX.TabIndex = 13;
            // 
            // ugyfelekModositBTN
            // 
            this.ugyfelekModositBTN.Location = new System.Drawing.Point(551, 132);
            this.ugyfelekModositBTN.Name = "ugyfelekModositBTN";
            this.ugyfelekModositBTN.Size = new System.Drawing.Size(246, 57);
            this.ugyfelekModositBTN.TabIndex = 12;
            this.ugyfelekModositBTN.Text = "Módosít";
            this.ugyfelekModositBTN.UseVisualStyleBackColor = true;
            this.ugyfelekModositBTN.Click += new System.EventHandler(this.ugyfelekModositBTN_Click);
            // 
            // ugyfelekTorolBTN
            // 
            this.ugyfelekTorolBTN.Location = new System.Drawing.Point(551, 69);
            this.ugyfelekTorolBTN.Name = "ugyfelekTorolBTN";
            this.ugyfelekTorolBTN.Size = new System.Drawing.Size(246, 57);
            this.ugyfelekTorolBTN.TabIndex = 11;
            this.ugyfelekTorolBTN.Text = "Töröl";
            this.ugyfelekTorolBTN.UseVisualStyleBackColor = true;
            this.ugyfelekTorolBTN.Click += new System.EventHandler(this.ugyfelekTorolBTN_Click);
            // 
            // ugyfelekFelveszBTN
            // 
            this.ugyfelekFelveszBTN.Location = new System.Drawing.Point(551, 6);
            this.ugyfelekFelveszBTN.Name = "ugyfelekFelveszBTN";
            this.ugyfelekFelveszBTN.Size = new System.Drawing.Size(246, 57);
            this.ugyfelekFelveszBTN.TabIndex = 10;
            this.ugyfelekFelveszBTN.Text = "Felvesz";
            this.ugyfelekFelveszBTN.UseVisualStyleBackColor = true;
            this.ugyfelekFelveszBTN.Click += new System.EventHandler(this.ugyfelekFelveszBTN_Click);
            // 
            // berlesekPage
            // 
            this.berlesekPage.Controls.Add(this.berlesekVisszahozasKmphTBOX);
            this.berlesekPage.Controls.Add(this.berlesekElvitelDatumTBOX);
            this.berlesekPage.Controls.Add(this.berlesekOsszegTBOX);
            this.berlesekPage.Controls.Add(this.berlesekVisszahozasDatumTBOX);
            this.berlesekPage.Controls.Add(this.berlesekElvitelKmphTBOX);
            this.berlesekPage.Controls.Add(this.berlesekUgyfelTBOX);
            this.berlesekPage.Controls.Add(this.berlesekAutoTBOX);
            this.berlesekPage.Controls.Add(this.berlesekModositBTN);
            this.berlesekPage.Controls.Add(this.berlesekTorolBTN);
            this.berlesekPage.Controls.Add(this.berlesekFelveszBtn);
            this.berlesekPage.Controls.Add(this.berlesekGrid);
            this.berlesekPage.Location = new System.Drawing.Point(4, 22);
            this.berlesekPage.Name = "berlesekPage";
            this.berlesekPage.Padding = new System.Windows.Forms.Padding(3);
            this.berlesekPage.Size = new System.Drawing.Size(803, 540);
            this.berlesekPage.TabIndex = 2;
            this.berlesekPage.Text = "Bérlések";
            this.berlesekPage.UseVisualStyleBackColor = true;
            // 
            // berlesekVisszahozasKmphTBOX
            // 
            this.berlesekVisszahozasKmphTBOX.Location = new System.Drawing.Point(551, 273);
            this.berlesekVisszahozasKmphTBOX.Name = "berlesekVisszahozasKmphTBOX";
            this.berlesekVisszahozasKmphTBOX.Size = new System.Drawing.Size(246, 20);
            this.berlesekVisszahozasKmphTBOX.TabIndex = 23;
            // 
            // berlesekElvitelDatumTBOX
            // 
            this.berlesekElvitelDatumTBOX.Location = new System.Drawing.Point(551, 299);
            this.berlesekElvitelDatumTBOX.Name = "berlesekElvitelDatumTBOX";
            this.berlesekElvitelDatumTBOX.Size = new System.Drawing.Size(246, 20);
            this.berlesekElvitelDatumTBOX.TabIndex = 24;
            // 
            // berlesekOsszegTBOX
            // 
            this.berlesekOsszegTBOX.Location = new System.Drawing.Point(551, 351);
            this.berlesekOsszegTBOX.Name = "berlesekOsszegTBOX";
            this.berlesekOsszegTBOX.Size = new System.Drawing.Size(246, 20);
            this.berlesekOsszegTBOX.TabIndex = 26;
            // 
            // berlesekVisszahozasDatumTBOX
            // 
            this.berlesekVisszahozasDatumTBOX.Location = new System.Drawing.Point(551, 325);
            this.berlesekVisszahozasDatumTBOX.Name = "berlesekVisszahozasDatumTBOX";
            this.berlesekVisszahozasDatumTBOX.Size = new System.Drawing.Size(246, 20);
            this.berlesekVisszahozasDatumTBOX.TabIndex = 25;
            // 
            // berlesekElvitelKmphTBOX
            // 
            this.berlesekElvitelKmphTBOX.Location = new System.Drawing.Point(551, 247);
            this.berlesekElvitelKmphTBOX.Name = "berlesekElvitelKmphTBOX";
            this.berlesekElvitelKmphTBOX.Size = new System.Drawing.Size(246, 20);
            this.berlesekElvitelKmphTBOX.TabIndex = 22;
            // 
            // berlesekUgyfelTBOX
            // 
            this.berlesekUgyfelTBOX.Location = new System.Drawing.Point(551, 221);
            this.berlesekUgyfelTBOX.Name = "berlesekUgyfelTBOX";
            this.berlesekUgyfelTBOX.Size = new System.Drawing.Size(246, 20);
            this.berlesekUgyfelTBOX.TabIndex = 21;
            // 
            // berlesekAutoTBOX
            // 
            this.berlesekAutoTBOX.Location = new System.Drawing.Point(551, 195);
            this.berlesekAutoTBOX.Name = "berlesekAutoTBOX";
            this.berlesekAutoTBOX.Size = new System.Drawing.Size(246, 20);
            this.berlesekAutoTBOX.TabIndex = 20;
            // 
            // berlesekModositBTN
            // 
            this.berlesekModositBTN.Location = new System.Drawing.Point(551, 132);
            this.berlesekModositBTN.Name = "berlesekModositBTN";
            this.berlesekModositBTN.Size = new System.Drawing.Size(246, 57);
            this.berlesekModositBTN.TabIndex = 19;
            this.berlesekModositBTN.Text = "Módosít";
            this.berlesekModositBTN.UseVisualStyleBackColor = true;
            this.berlesekModositBTN.Click += new System.EventHandler(this.berlesekModositBTN_Click);
            // 
            // berlesekTorolBTN
            // 
            this.berlesekTorolBTN.Location = new System.Drawing.Point(551, 69);
            this.berlesekTorolBTN.Name = "berlesekTorolBTN";
            this.berlesekTorolBTN.Size = new System.Drawing.Size(246, 57);
            this.berlesekTorolBTN.TabIndex = 18;
            this.berlesekTorolBTN.Text = "Töröl";
            this.berlesekTorolBTN.UseVisualStyleBackColor = true;
            this.berlesekTorolBTN.Click += new System.EventHandler(this.berlesekTorolBTN_Click);
            // 
            // berlesekFelveszBtn
            // 
            this.berlesekFelveszBtn.Location = new System.Drawing.Point(551, 6);
            this.berlesekFelveszBtn.Name = "berlesekFelveszBtn";
            this.berlesekFelveszBtn.Size = new System.Drawing.Size(246, 57);
            this.berlesekFelveszBtn.TabIndex = 17;
            this.berlesekFelveszBtn.Text = "Felvesz";
            this.berlesekFelveszBtn.UseVisualStyleBackColor = true;
            this.berlesekFelveszBtn.Click += new System.EventHandler(this.berlesekFelveszBtn_Click);
            // 
            // berlesekGrid
            // 
            this.berlesekGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.berlesekGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.berlesekGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.auto,
            this.ugyfel,
            this.elvitelkmh,
            this.visszahozaskmh,
            this.elviteldatum,
            this.visszahozdatum,
            this.osszeg});
            this.berlesekGrid.Location = new System.Drawing.Point(0, 0);
            this.berlesekGrid.MultiSelect = false;
            this.berlesekGrid.Name = "berlesekGrid";
            this.berlesekGrid.ReadOnly = true;
            this.berlesekGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.berlesekGrid.Size = new System.Drawing.Size(545, 540);
            this.berlesekGrid.TabIndex = 16;
            // 
            // auto
            // 
            this.auto.HeaderText = "Autó";
            this.auto.Name = "auto";
            this.auto.ReadOnly = true;
            // 
            // ugyfel
            // 
            this.ugyfel.HeaderText = "Ügyfél";
            this.ugyfel.Name = "ugyfel";
            this.ugyfel.ReadOnly = true;
            // 
            // elvitelkmh
            // 
            this.elvitelkmh.HeaderText = "Elvitel Km/h";
            this.elvitelkmh.Name = "elvitelkmh";
            this.elvitelkmh.ReadOnly = true;
            // 
            // visszahozaskmh
            // 
            this.visszahozaskmh.HeaderText = "Visszahozás Km/h";
            this.visszahozaskmh.Name = "visszahozaskmh";
            this.visszahozaskmh.ReadOnly = true;
            // 
            // elviteldatum
            // 
            this.elviteldatum.HeaderText = "Elvitel dátum";
            this.elviteldatum.Name = "elviteldatum";
            this.elviteldatum.ReadOnly = true;
            // 
            // visszahozdatum
            // 
            this.visszahozdatum.HeaderText = "Visszahozás dátum";
            this.visszahozdatum.Name = "visszahozdatum";
            this.visszahozdatum.ReadOnly = true;
            // 
            // osszeg
            // 
            this.osszeg.HeaderText = "Összeg";
            this.osszeg.Name = "osszeg";
            this.osszeg.ReadOnly = true;
            // 
            // statButton
            // 
            this.statButton.Location = new System.Drawing.Point(997, 86);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(75, 427);
            this.statButton.TabIndex = 5;
            this.statButton.Text = "Statisztika";
            this.statButton.UseVisualStyleBackColor = true;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 590);
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Autóbérlés";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.autokGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelekGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.autokPage.ResumeLayout(false);
            this.autokPage.PerformLayout();
            this.ugyfelekPage.ResumeLayout(false);
            this.ugyfelekPage.PerformLayout();
            this.berlesekPage.ResumeLayout(false);
            this.berlesekPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.berlesekGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView autokGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn modell;
        private System.Windows.Forms.DataGridViewTextBoxColumn km;
        private System.Windows.Forms.Button autokFelveszBTN;
        private System.Windows.Forms.DataGridView ugyfelekGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn szemelyiSzam;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn lakcim;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage autokPage;
        private System.Windows.Forms.TextBox autoKmTBOX;
        private System.Windows.Forms.TextBox autokModellTBOX;
        private System.Windows.Forms.TextBox autokGyartoTBOX;
        private System.Windows.Forms.TextBox autokTipusTBOX;
        private System.Windows.Forms.TextBox autokRendszamTBOX;
        private System.Windows.Forms.Button autokModositBTN;
        private System.Windows.Forms.Button autokTorolBTN;
        private System.Windows.Forms.TabPage ugyfelekPage;
        private System.Windows.Forms.TextBox ugyfelekLakcimTBOX;
        private System.Windows.Forms.TextBox ugyfelekNevTBOX;
        private System.Windows.Forms.TextBox ugyfelekSzemelyiTBOX;
        private System.Windows.Forms.Button ugyfelekModositBTN;
        private System.Windows.Forms.Button ugyfelekTorolBTN;
        private System.Windows.Forms.Button ugyfelekFelveszBTN;
        private System.Windows.Forms.TabPage berlesekPage;
        private System.Windows.Forms.TextBox berlesekVisszahozasDatumTBOX;
        private System.Windows.Forms.TextBox berlesekElvitelKmphTBOX;
        private System.Windows.Forms.TextBox berlesekUgyfelTBOX;
        private System.Windows.Forms.TextBox berlesekAutoTBOX;
        private System.Windows.Forms.Button berlesekModositBTN;
        private System.Windows.Forms.Button berlesekTorolBTN;
        private System.Windows.Forms.Button berlesekFelveszBtn;
        private System.Windows.Forms.DataGridView berlesekGrid;
        private System.Windows.Forms.Button statButton;
        private System.Windows.Forms.TextBox berlesekOsszegTBOX;
        private System.Windows.Forms.TextBox berlesekVisszahozasKmphTBOX;
        private System.Windows.Forms.TextBox berlesekElvitelDatumTBOX;
        private System.Windows.Forms.DataGridViewTextBoxColumn auto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugyfel;
        private System.Windows.Forms.DataGridViewTextBoxColumn elvitelkmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn visszahozaskmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn elviteldatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn visszahozdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn osszeg;
    }
}

