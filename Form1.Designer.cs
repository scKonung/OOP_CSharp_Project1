
namespace Projektnr1_Chalyi_59022
{
    partial class Projekt1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projekt1));
            this.Zakładki = new System.Windows.Forms.TabControl();
            this.tabPageKokpit = new System.Windows.Forms.TabPage();
            this.bttn_Zespolone = new System.Windows.Forms.Button();
            this.bttn_Macierze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageMacieze = new System.Windows.Forms.TabPage();
            this.groupBoxPrzysickiOperacyjne = new System.Windows.Forms.GroupBox();
            this.bttnAkceptujB = new System.Windows.Forms.Button();
            this.bttnWygenerujB = new System.Windows.Forms.Button();
            this.bttnUtworzB = new System.Windows.Forms.Button();
            this.bttnAkceptujA = new System.Windows.Forms.Button();
            this.bttnWygenerujA = new System.Windows.Forms.Button();
            this.bttnUtworzA = new System.Windows.Forms.Button();
            this.groupBoxKalkulatorMacierzowy = new System.Windows.Forms.GroupBox();
            this.bttnIloczynAB = new System.Windows.Forms.Button();
            this.bttnBminusA = new System.Windows.Forms.Button();
            this.bttnAminusB = new System.Windows.Forms.Button();
            this.bttnAplusB = new System.Windows.Forms.Button();
            this.groupBoxOpisRozmiaruMacierzy = new System.Windows.Forms.GroupBox();
            this.txtBoxLiczbaKolumn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxLiczbaWierzy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttn_return_z_Macierze = new System.Windows.Forms.Button();
            this.tabPageZespolone = new System.Windows.Forms.TabPage();
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxKalkulator = new System.Windows.Forms.GroupBox();
            this.bttnZ_sprzezona_A = new System.Windows.Forms.Button();
            this.bttnZ_modulA = new System.Windows.Forms.Button();
            this.bttn_Z_A_dzielic_B = new System.Windows.Forms.Button();
            this.bttnZ_A_iloczyn_B = new System.Windows.Forms.Button();
            this.bttnZ_A_minus_B = new System.Windows.Forms.Button();
            this.bttnZ_A_plus_B = new System.Windows.Forms.Button();
            this.groupBoxLiczbaB = new System.Windows.Forms.GroupBox();
            this.txtIm2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRe2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bttnReset = new System.Windows.Forms.Button();
            this.groupBoxLiczbaA = new System.Windows.Forms.GroupBox();
            this.txtIm1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRe1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxIlośćliczb = new System.Windows.Forms.GroupBox();
            this.radioButtonDwieLiczby = new System.Windows.Forms.RadioButton();
            this.radioButtonJednaLiczba = new System.Windows.Forms.RadioButton();
            this.bttn_return_z_Zespolonych = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Zakładki.SuspendLayout();
            this.tabPageKokpit.SuspendLayout();
            this.tabPageMacieze.SuspendLayout();
            this.groupBoxPrzysickiOperacyjne.SuspendLayout();
            this.groupBoxKalkulatorMacierzowy.SuspendLayout();
            this.groupBoxOpisRozmiaruMacierzy.SuspendLayout();
            this.tabPageZespolone.SuspendLayout();
            this.groupBoxKalkulator.SuspendLayout();
            this.groupBoxLiczbaB.SuspendLayout();
            this.groupBoxLiczbaA.SuspendLayout();
            this.groupBoxIlośćliczb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // Zakładki
            // 
            this.Zakładki.Controls.Add(this.tabPageKokpit);
            this.Zakładki.Controls.Add(this.tabPageMacieze);
            this.Zakładki.Controls.Add(this.tabPageZespolone);
            this.Zakładki.Location = new System.Drawing.Point(-1, 1);
            this.Zakładki.Name = "Zakładki";
            this.Zakładki.SelectedIndex = 0;
            this.Zakładki.Size = new System.Drawing.Size(797, 448);
            this.Zakładki.TabIndex = 0;
            this.Zakładki.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Zakładki_Selecting);
            // 
            // tabPageKokpit
            // 
            this.tabPageKokpit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPageKokpit.Controls.Add(this.bttn_Zespolone);
            this.tabPageKokpit.Controls.Add(this.bttn_Macierze);
            this.tabPageKokpit.Controls.Add(this.label1);
            this.tabPageKokpit.Location = new System.Drawing.Point(4, 22);
            this.tabPageKokpit.Name = "tabPageKokpit";
            this.tabPageKokpit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKokpit.Size = new System.Drawing.Size(789, 422);
            this.tabPageKokpit.TabIndex = 0;
            this.tabPageKokpit.Text = "Kokpit";
            // 
            // bttn_Zespolone
            // 
            this.bttn_Zespolone.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttn_Zespolone.Location = new System.Drawing.Point(546, 218);
            this.bttn_Zespolone.Name = "bttn_Zespolone";
            this.bttn_Zespolone.Size = new System.Drawing.Size(200, 85);
            this.bttn_Zespolone.TabIndex = 2;
            this.bttn_Zespolone.Text = "Kalkulator obliczeń na liczbach zespolonych";
            this.bttn_Zespolone.UseVisualStyleBackColor = true;
            this.bttn_Zespolone.Click += new System.EventHandler(this.bttn_Zespolone_Click);
            // 
            // bttn_Macierze
            // 
            this.bttn_Macierze.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttn_Macierze.Location = new System.Drawing.Point(67, 218);
            this.bttn_Macierze.Name = "bttn_Macierze";
            this.bttn_Macierze.Size = new System.Drawing.Size(200, 85);
            this.bttn_Macierze.TabIndex = 1;
            this.bttn_Macierze.Text = "Kalkulator obliczeń na macierzach";
            this.bttn_Macierze.UseVisualStyleBackColor = true;
            this.bttn_Macierze.Click += new System.EventHandler(this.bttn_Macierze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(152, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Przeciązanie metod i operatorów\r\n                    w języka C#";
            // 
            // tabPageMacieze
            // 
            this.tabPageMacieze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPageMacieze.Controls.Add(this.groupBoxPrzysickiOperacyjne);
            this.tabPageMacieze.Controls.Add(this.groupBoxKalkulatorMacierzowy);
            this.tabPageMacieze.Controls.Add(this.groupBoxOpisRozmiaruMacierzy);
            this.tabPageMacieze.Controls.Add(this.bttn_return_z_Macierze);
            this.tabPageMacieze.Location = new System.Drawing.Point(4, 22);
            this.tabPageMacieze.Name = "tabPageMacieze";
            this.tabPageMacieze.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMacieze.Size = new System.Drawing.Size(789, 422);
            this.tabPageMacieze.TabIndex = 1;
            this.tabPageMacieze.Text = "Dzialanie na macierzach";
            // 
            // groupBoxPrzysickiOperacyjne
            // 
            this.groupBoxPrzysickiOperacyjne.Controls.Add(this.bttnAkceptujB);
            this.groupBoxPrzysickiOperacyjne.Controls.Add(this.bttnWygenerujB);
            this.groupBoxPrzysickiOperacyjne.Controls.Add(this.bttnUtworzB);
            this.groupBoxPrzysickiOperacyjne.Controls.Add(this.bttnAkceptujA);
            this.groupBoxPrzysickiOperacyjne.Controls.Add(this.bttnWygenerujA);
            this.groupBoxPrzysickiOperacyjne.Controls.Add(this.bttnUtworzA);
            this.groupBoxPrzysickiOperacyjne.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxPrzysickiOperacyjne.Location = new System.Drawing.Point(569, 6);
            this.groupBoxPrzysickiOperacyjne.Name = "groupBoxPrzysickiOperacyjne";
            this.groupBoxPrzysickiOperacyjne.Size = new System.Drawing.Size(224, 403);
            this.groupBoxPrzysickiOperacyjne.TabIndex = 5;
            this.groupBoxPrzysickiOperacyjne.TabStop = false;
            this.groupBoxPrzysickiOperacyjne.Text = "Przyciski operacyjne";
            // 
            // bttnAkceptujB
            // 
            this.bttnAkceptujB.Enabled = false;
            this.bttnAkceptujB.Location = new System.Drawing.Point(3, 344);
            this.bttnAkceptujB.Name = "bttnAkceptujB";
            this.bttnAkceptujB.Size = new System.Drawing.Size(212, 50);
            this.bttnAkceptujB.TabIndex = 5;
            this.bttnAkceptujB.Text = "Akceptuj wartości elementów macierzy B";
            this.bttnAkceptujB.UseVisualStyleBackColor = true;
            this.bttnAkceptujB.Click += new System.EventHandler(this.bttnAkceptujB_Click);
            // 
            // bttnWygenerujB
            // 
            this.bttnWygenerujB.Enabled = false;
            this.bttnWygenerujB.Location = new System.Drawing.Point(3, 289);
            this.bttnWygenerujB.Name = "bttnWygenerujB";
            this.bttnWygenerujB.Size = new System.Drawing.Size(212, 48);
            this.bttnWygenerujB.TabIndex = 4;
            this.bttnWygenerujB.Text = "Wygeneruj losowo wartości elementów macierzy B";
            this.bttnWygenerujB.UseVisualStyleBackColor = true;
            this.bttnWygenerujB.Click += new System.EventHandler(this.bttnWygenerujB_Click);
            // 
            // bttnUtworzB
            // 
            this.bttnUtworzB.Enabled = false;
            this.bttnUtworzB.Location = new System.Drawing.Point(3, 217);
            this.bttnUtworzB.Name = "bttnUtworzB";
            this.bttnUtworzB.Size = new System.Drawing.Size(213, 66);
            this.bttnUtworzB.TabIndex = 3;
            this.bttnUtworzB.Text = "Utwórz kontrolkę DataGridView dla macierzy B";
            this.bttnUtworzB.UseVisualStyleBackColor = true;
            this.bttnUtworzB.Click += new System.EventHandler(this.bttnUtworzB_Click);
            // 
            // bttnAkceptujA
            // 
            this.bttnAkceptujA.Enabled = false;
            this.bttnAkceptujA.Location = new System.Drawing.Point(3, 145);
            this.bttnAkceptujA.Name = "bttnAkceptujA";
            this.bttnAkceptujA.Size = new System.Drawing.Size(211, 50);
            this.bttnAkceptujA.TabIndex = 2;
            this.bttnAkceptujA.Text = "Akceptuj wartości elementów macierzy A";
            this.bttnAkceptujA.UseVisualStyleBackColor = true;
            this.bttnAkceptujA.Click += new System.EventHandler(this.bttnAkceptujA_Click);
            // 
            // bttnWygenerujA
            // 
            this.bttnWygenerujA.Enabled = false;
            this.bttnWygenerujA.Location = new System.Drawing.Point(3, 91);
            this.bttnWygenerujA.Name = "bttnWygenerujA";
            this.bttnWygenerujA.Size = new System.Drawing.Size(212, 48);
            this.bttnWygenerujA.TabIndex = 1;
            this.bttnWygenerujA.Text = "Wygeneruj losowo wartości elementów macierzy A";
            this.bttnWygenerujA.UseVisualStyleBackColor = true;
            this.bttnWygenerujA.Click += new System.EventHandler(this.bttnWygenerujA_Click);
            // 
            // bttnUtworzA
            // 
            this.bttnUtworzA.Location = new System.Drawing.Point(3, 16);
            this.bttnUtworzA.Name = "bttnUtworzA";
            this.bttnUtworzA.Size = new System.Drawing.Size(212, 69);
            this.bttnUtworzA.TabIndex = 0;
            this.bttnUtworzA.Text = "Utwórz kontrolkę DataGridView dla macierzy A";
            this.bttnUtworzA.UseVisualStyleBackColor = true;
            this.bttnUtworzA.Click += new System.EventHandler(this.bttnUtworzA_Click);
            // 
            // groupBoxKalkulatorMacierzowy
            // 
            this.groupBoxKalkulatorMacierzowy.Controls.Add(this.bttnIloczynAB);
            this.groupBoxKalkulatorMacierzowy.Controls.Add(this.bttnBminusA);
            this.groupBoxKalkulatorMacierzowy.Controls.Add(this.bttnAminusB);
            this.groupBoxKalkulatorMacierzowy.Controls.Add(this.bttnAplusB);
            this.groupBoxKalkulatorMacierzowy.Enabled = false;
            this.groupBoxKalkulatorMacierzowy.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxKalkulatorMacierzowy.Location = new System.Drawing.Point(6, 223);
            this.groupBoxKalkulatorMacierzowy.Name = "groupBoxKalkulatorMacierzowy";
            this.groupBoxKalkulatorMacierzowy.Size = new System.Drawing.Size(200, 143);
            this.groupBoxKalkulatorMacierzowy.TabIndex = 4;
            this.groupBoxKalkulatorMacierzowy.TabStop = false;
            this.groupBoxKalkulatorMacierzowy.Text = "Kalkulator Macierzowy";
            // 
            // bttnIloczynAB
            // 
            this.bttnIloczynAB.Location = new System.Drawing.Point(47, 105);
            this.bttnIloczynAB.Name = "bttnIloczynAB";
            this.bttnIloczynAB.Size = new System.Drawing.Size(75, 23);
            this.bttnIloczynAB.TabIndex = 3;
            this.bttnIloczynAB.Text = "C = A * B";
            this.bttnIloczynAB.UseVisualStyleBackColor = true;
            this.bttnIloczynAB.Click += new System.EventHandler(this.bttnIloczynAB_Click);
            // 
            // bttnBminusA
            // 
            this.bttnBminusA.Location = new System.Drawing.Point(47, 76);
            this.bttnBminusA.Name = "bttnBminusA";
            this.bttnBminusA.Size = new System.Drawing.Size(75, 23);
            this.bttnBminusA.TabIndex = 2;
            this.bttnBminusA.Text = "C = B - A";
            this.bttnBminusA.UseVisualStyleBackColor = true;
            this.bttnBminusA.Click += new System.EventHandler(this.bttnBminusA_Click);
            // 
            // bttnAminusB
            // 
            this.bttnAminusB.Location = new System.Drawing.Point(47, 47);
            this.bttnAminusB.Name = "bttnAminusB";
            this.bttnAminusB.Size = new System.Drawing.Size(75, 23);
            this.bttnAminusB.TabIndex = 1;
            this.bttnAminusB.Text = "C = A - B";
            this.bttnAminusB.UseVisualStyleBackColor = true;
            this.bttnAminusB.Click += new System.EventHandler(this.bttnAminusB_Click);
            // 
            // bttnAplusB
            // 
            this.bttnAplusB.Location = new System.Drawing.Point(47, 18);
            this.bttnAplusB.Name = "bttnAplusB";
            this.bttnAplusB.Size = new System.Drawing.Size(75, 23);
            this.bttnAplusB.TabIndex = 0;
            this.bttnAplusB.Text = "C = A + B";
            this.bttnAplusB.UseVisualStyleBackColor = true;
            this.bttnAplusB.Click += new System.EventHandler(this.bttnAplusB_Click);
            // 
            // groupBoxOpisRozmiaruMacierzy
            // 
            this.groupBoxOpisRozmiaruMacierzy.Controls.Add(this.txtBoxLiczbaKolumn);
            this.groupBoxOpisRozmiaruMacierzy.Controls.Add(this.label3);
            this.groupBoxOpisRozmiaruMacierzy.Controls.Add(this.txtBoxLiczbaWierzy);
            this.groupBoxOpisRozmiaruMacierzy.Controls.Add(this.label2);
            this.groupBoxOpisRozmiaruMacierzy.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxOpisRozmiaruMacierzy.Location = new System.Drawing.Point(9, 97);
            this.groupBoxOpisRozmiaruMacierzy.Name = "groupBoxOpisRozmiaruMacierzy";
            this.groupBoxOpisRozmiaruMacierzy.Size = new System.Drawing.Size(200, 120);
            this.groupBoxOpisRozmiaruMacierzy.TabIndex = 3;
            this.groupBoxOpisRozmiaruMacierzy.TabStop = false;
            this.groupBoxOpisRozmiaruMacierzy.Text = "Opis rozmiaru macierzy";
            // 
            // txtBoxLiczbaKolumn
            // 
            this.txtBoxLiczbaKolumn.Location = new System.Drawing.Point(44, 87);
            this.txtBoxLiczbaKolumn.Name = "txtBoxLiczbaKolumn";
            this.txtBoxLiczbaKolumn.Size = new System.Drawing.Size(100, 23);
            this.txtBoxLiczbaKolumn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liczba kolumn";
            // 
            // txtBoxLiczbaWierzy
            // 
            this.txtBoxLiczbaWierzy.Location = new System.Drawing.Point(44, 40);
            this.txtBoxLiczbaWierzy.Name = "txtBoxLiczbaWierzy";
            this.txtBoxLiczbaWierzy.Size = new System.Drawing.Size(100, 23);
            this.txtBoxLiczbaWierzy.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Liczba wierzy";
            // 
            // bttn_return_z_Macierze
            // 
            this.bttn_return_z_Macierze.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttn_return_z_Macierze.Location = new System.Drawing.Point(9, 16);
            this.bttn_return_z_Macierze.Name = "bttn_return_z_Macierze";
            this.bttn_return_z_Macierze.Size = new System.Drawing.Size(163, 58);
            this.bttn_return_z_Macierze.TabIndex = 2;
            this.bttn_return_z_Macierze.Text = "Powrót do zakladki Kokpit";
            this.bttn_return_z_Macierze.UseVisualStyleBackColor = true;
            this.bttn_return_z_Macierze.Click += new System.EventHandler(this.bttn_return_z_Macierze_Click);
            // 
            // tabPageZespolone
            // 
            this.tabPageZespolone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageZespolone.Controls.Add(this.txtWynik);
            this.tabPageZespolone.Controls.Add(this.label8);
            this.tabPageZespolone.Controls.Add(this.groupBoxKalkulator);
            this.tabPageZespolone.Controls.Add(this.groupBoxLiczbaB);
            this.tabPageZespolone.Controls.Add(this.bttnReset);
            this.tabPageZespolone.Controls.Add(this.groupBoxLiczbaA);
            this.tabPageZespolone.Controls.Add(this.groupBoxIlośćliczb);
            this.tabPageZespolone.Controls.Add(this.bttn_return_z_Zespolonych);
            this.tabPageZespolone.Location = new System.Drawing.Point(4, 22);
            this.tabPageZespolone.Name = "tabPageZespolone";
            this.tabPageZespolone.Size = new System.Drawing.Size(789, 422);
            this.tabPageZespolone.TabIndex = 2;
            this.tabPageZespolone.Text = "Dzialanie na liczbach zespołonaych";
            // 
            // txtWynik
            // 
            this.txtWynik.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWynik.Location = new System.Drawing.Point(30, 350);
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.ReadOnly = true;
            this.txtWynik.Size = new System.Drawing.Size(187, 26);
            this.txtWynik.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(26, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Wyniki obliczeń:";
            // 
            // groupBoxKalkulator
            // 
            this.groupBoxKalkulator.Controls.Add(this.bttnZ_sprzezona_A);
            this.groupBoxKalkulator.Controls.Add(this.bttnZ_modulA);
            this.groupBoxKalkulator.Controls.Add(this.bttn_Z_A_dzielic_B);
            this.groupBoxKalkulator.Controls.Add(this.bttnZ_A_iloczyn_B);
            this.groupBoxKalkulator.Controls.Add(this.bttnZ_A_minus_B);
            this.groupBoxKalkulator.Controls.Add(this.bttnZ_A_plus_B);
            this.groupBoxKalkulator.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxKalkulator.Location = new System.Drawing.Point(434, 118);
            this.groupBoxKalkulator.Name = "groupBoxKalkulator";
            this.groupBoxKalkulator.Size = new System.Drawing.Size(325, 297);
            this.groupBoxKalkulator.TabIndex = 10;
            this.groupBoxKalkulator.TabStop = false;
            this.groupBoxKalkulator.Text = "Kalkulator";
            // 
            // bttnZ_sprzezona_A
            // 
            this.bttnZ_sprzezona_A.Enabled = false;
            this.bttnZ_sprzezona_A.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnZ_sprzezona_A.Location = new System.Drawing.Point(183, 88);
            this.bttnZ_sprzezona_A.Name = "bttnZ_sprzezona_A";
            this.bttnZ_sprzezona_A.Size = new System.Drawing.Size(123, 58);
            this.bttnZ_sprzezona_A.TabIndex = 17;
            this.bttnZ_sprzezona_A.Text = "Z = A~";
            this.bttnZ_sprzezona_A.UseVisualStyleBackColor = true;
            this.bttnZ_sprzezona_A.Click += new System.EventHandler(this.bttnZ_sprzezona_A_Click);
            // 
            // bttnZ_modulA
            // 
            this.bttnZ_modulA.Enabled = false;
            this.bttnZ_modulA.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnZ_modulA.Location = new System.Drawing.Point(183, 24);
            this.bttnZ_modulA.Name = "bttnZ_modulA";
            this.bttnZ_modulA.Size = new System.Drawing.Size(123, 58);
            this.bttnZ_modulA.TabIndex = 16;
            this.bttnZ_modulA.Text = "Z = |A|";
            this.bttnZ_modulA.UseVisualStyleBackColor = true;
            this.bttnZ_modulA.Click += new System.EventHandler(this.bttnZ_modulA_Click);
            // 
            // bttn_Z_A_dzielic_B
            // 
            this.bttn_Z_A_dzielic_B.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttn_Z_A_dzielic_B.Location = new System.Drawing.Point(21, 215);
            this.bttn_Z_A_dzielic_B.Name = "bttn_Z_A_dzielic_B";
            this.bttn_Z_A_dzielic_B.Size = new System.Drawing.Size(123, 58);
            this.bttn_Z_A_dzielic_B.TabIndex = 15;
            this.bttn_Z_A_dzielic_B.Text = "Z = A / B";
            this.bttn_Z_A_dzielic_B.UseVisualStyleBackColor = true;
            this.bttn_Z_A_dzielic_B.Click += new System.EventHandler(this.bttn_Z_A_dzielic_B_Click);
            // 
            // bttnZ_A_iloczyn_B
            // 
            this.bttnZ_A_iloczyn_B.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnZ_A_iloczyn_B.Location = new System.Drawing.Point(21, 152);
            this.bttnZ_A_iloczyn_B.Name = "bttnZ_A_iloczyn_B";
            this.bttnZ_A_iloczyn_B.Size = new System.Drawing.Size(123, 58);
            this.bttnZ_A_iloczyn_B.TabIndex = 14;
            this.bttnZ_A_iloczyn_B.Text = "Z = A * B";
            this.bttnZ_A_iloczyn_B.UseVisualStyleBackColor = true;
            this.bttnZ_A_iloczyn_B.Click += new System.EventHandler(this.bttnZ_A_iloczyn_B_Click);
            // 
            // bttnZ_A_minus_B
            // 
            this.bttnZ_A_minus_B.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnZ_A_minus_B.Location = new System.Drawing.Point(21, 88);
            this.bttnZ_A_minus_B.Name = "bttnZ_A_minus_B";
            this.bttnZ_A_minus_B.Size = new System.Drawing.Size(123, 58);
            this.bttnZ_A_minus_B.TabIndex = 12;
            this.bttnZ_A_minus_B.Text = "Z = A - B";
            this.bttnZ_A_minus_B.UseVisualStyleBackColor = true;
            this.bttnZ_A_minus_B.Click += new System.EventHandler(this.bttnZ_A_minus_B_Click);
            // 
            // bttnZ_A_plus_B
            // 
            this.bttnZ_A_plus_B.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnZ_A_plus_B.Location = new System.Drawing.Point(21, 24);
            this.bttnZ_A_plus_B.Name = "bttnZ_A_plus_B";
            this.bttnZ_A_plus_B.Size = new System.Drawing.Size(123, 58);
            this.bttnZ_A_plus_B.TabIndex = 11;
            this.bttnZ_A_plus_B.Text = "Z = A + B";
            this.bttnZ_A_plus_B.UseVisualStyleBackColor = true;
            this.bttnZ_A_plus_B.Click += new System.EventHandler(this.bttnZ_A_plus_B_Click);
            // 
            // groupBoxLiczbaB
            // 
            this.groupBoxLiczbaB.Controls.Add(this.txtIm2);
            this.groupBoxLiczbaB.Controls.Add(this.label6);
            this.groupBoxLiczbaB.Controls.Add(this.txtRe2);
            this.groupBoxLiczbaB.Controls.Add(this.label7);
            this.groupBoxLiczbaB.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxLiczbaB.Location = new System.Drawing.Point(9, 182);
            this.groupBoxLiczbaB.Name = "groupBoxLiczbaB";
            this.groupBoxLiczbaB.Size = new System.Drawing.Size(344, 94);
            this.groupBoxLiczbaB.TabIndex = 8;
            this.groupBoxLiczbaB.TabStop = false;
            this.groupBoxLiczbaB.Text = "Liczba B";
            // 
            // txtIm2
            // 
            this.txtIm2.Location = new System.Drawing.Point(175, 55);
            this.txtIm2.Name = "txtIm2";
            this.txtIm2.Size = new System.Drawing.Size(100, 25);
            this.txtIm2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Im:";
            // 
            // txtRe2
            // 
            this.txtRe2.Location = new System.Drawing.Point(20, 55);
            this.txtRe2.Name = "txtRe2";
            this.txtRe2.Size = new System.Drawing.Size(100, 25);
            this.txtRe2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Re:";
            // 
            // bttnReset
            // 
            this.bttnReset.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnReset.Location = new System.Drawing.Point(186, 12);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(163, 58);
            this.bttnReset.TabIndex = 6;
            this.bttnReset.Text = "Resetuj";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // groupBoxLiczbaA
            // 
            this.groupBoxLiczbaA.Controls.Add(this.txtIm1);
            this.groupBoxLiczbaA.Controls.Add(this.label4);
            this.groupBoxLiczbaA.Controls.Add(this.txtRe1);
            this.groupBoxLiczbaA.Controls.Add(this.label5);
            this.groupBoxLiczbaA.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxLiczbaA.Location = new System.Drawing.Point(9, 82);
            this.groupBoxLiczbaA.Name = "groupBoxLiczbaA";
            this.groupBoxLiczbaA.Size = new System.Drawing.Size(344, 94);
            this.groupBoxLiczbaA.TabIndex = 5;
            this.groupBoxLiczbaA.TabStop = false;
            this.groupBoxLiczbaA.Text = "Liczba A";
            // 
            // txtIm1
            // 
            this.txtIm1.Location = new System.Drawing.Point(175, 55);
            this.txtIm1.Name = "txtIm1";
            this.txtIm1.Size = new System.Drawing.Size(100, 25);
            this.txtIm1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Im:";
            // 
            // txtRe1
            // 
            this.txtRe1.Location = new System.Drawing.Point(20, 55);
            this.txtRe1.Name = "txtRe1";
            this.txtRe1.Size = new System.Drawing.Size(100, 25);
            this.txtRe1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Re:";
            // 
            // groupBoxIlośćliczb
            // 
            this.groupBoxIlośćliczb.Controls.Add(this.radioButtonDwieLiczby);
            this.groupBoxIlośćliczb.Controls.Add(this.radioButtonJednaLiczba);
            this.groupBoxIlośćliczb.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxIlośćliczb.Location = new System.Drawing.Point(403, 27);
            this.groupBoxIlośćliczb.Name = "groupBoxIlośćliczb";
            this.groupBoxIlośćliczb.Size = new System.Drawing.Size(344, 85);
            this.groupBoxIlośćliczb.TabIndex = 4;
            this.groupBoxIlośćliczb.TabStop = false;
            this.groupBoxIlośćliczb.Text = "Ilośc liczb";
            this.groupBoxIlośćliczb.Enter += new System.EventHandler(this.groupBoxIlośćliczb_Enter);
            // 
            // radioButtonDwieLiczby
            // 
            this.radioButtonDwieLiczby.AutoSize = true;
            this.radioButtonDwieLiczby.Checked = true;
            this.radioButtonDwieLiczby.Location = new System.Drawing.Point(6, 55);
            this.radioButtonDwieLiczby.Name = "radioButtonDwieLiczby";
            this.radioButtonDwieLiczby.Size = new System.Drawing.Size(322, 23);
            this.radioButtonDwieLiczby.TabIndex = 1;
            this.radioButtonDwieLiczby.TabStop = true;
            this.radioButtonDwieLiczby.Text = "Dzialanie na dwóch liczbach zespołonych";
            this.radioButtonDwieLiczby.UseVisualStyleBackColor = true;
            this.radioButtonDwieLiczby.UseWaitCursor = true;
            this.radioButtonDwieLiczby.CheckedChanged += new System.EventHandler(this.radioButtonDwieLiczby_CheckedChanged);
            // 
            // radioButtonJednaLiczba
            // 
            this.radioButtonJednaLiczba.AutoSize = true;
            this.radioButtonJednaLiczba.Location = new System.Drawing.Point(6, 26);
            this.radioButtonJednaLiczba.Name = "radioButtonJednaLiczba";
            this.radioButtonJednaLiczba.Size = new System.Drawing.Size(289, 23);
            this.radioButtonJednaLiczba.TabIndex = 0;
            this.radioButtonJednaLiczba.Text = "Dzialanie na jednej liczbe zespołonej";
            this.radioButtonJednaLiczba.UseVisualStyleBackColor = true;
            this.radioButtonJednaLiczba.CheckedChanged += new System.EventHandler(this.radioButtonJednaLiczba_CheckedChanged);
            // 
            // bttn_return_z_Zespolonych
            // 
            this.bttn_return_z_Zespolonych.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttn_return_z_Zespolonych.Location = new System.Drawing.Point(9, 12);
            this.bttn_return_z_Zespolonych.Name = "bttn_return_z_Zespolonych";
            this.bttn_return_z_Zespolonych.Size = new System.Drawing.Size(163, 58);
            this.bttn_return_z_Zespolonych.TabIndex = 3;
            this.bttn_return_z_Zespolonych.Text = "Powrót do zakladki Kokpit";
            this.bttn_return_z_Zespolonych.UseVisualStyleBackColor = true;
            this.bttn_return_z_Zespolonych.Click += new System.EventHandler(this.bttn_return_z_Zespolonych_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // Projekt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zakładki);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Projekt1";
            this.Text = "Przeciązenie operatorów w języku C#";
            this.Zakładki.ResumeLayout(false);
            this.tabPageKokpit.ResumeLayout(false);
            this.tabPageKokpit.PerformLayout();
            this.tabPageMacieze.ResumeLayout(false);
            this.groupBoxPrzysickiOperacyjne.ResumeLayout(false);
            this.groupBoxKalkulatorMacierzowy.ResumeLayout(false);
            this.groupBoxOpisRozmiaruMacierzy.ResumeLayout(false);
            this.groupBoxOpisRozmiaruMacierzy.PerformLayout();
            this.tabPageZespolone.ResumeLayout(false);
            this.tabPageZespolone.PerformLayout();
            this.groupBoxKalkulator.ResumeLayout(false);
            this.groupBoxLiczbaB.ResumeLayout(false);
            this.groupBoxLiczbaB.PerformLayout();
            this.groupBoxLiczbaA.ResumeLayout(false);
            this.groupBoxLiczbaA.PerformLayout();
            this.groupBoxIlośćliczb.ResumeLayout(false);
            this.groupBoxIlośćliczb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Zakładki;
        private System.Windows.Forms.TabPage tabPageKokpit;
        private System.Windows.Forms.TabPage tabPageMacieze;
        private System.Windows.Forms.TabPage tabPageZespolone;
        private System.Windows.Forms.Button bttn_Zespolone;
        private System.Windows.Forms.Button bttn_Macierze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_return_z_Macierze;
        private System.Windows.Forms.Button bttn_return_z_Zespolonych;
        private System.Windows.Forms.GroupBox groupBoxOpisRozmiaruMacierzy;
        private System.Windows.Forms.TextBox txtBoxLiczbaWierzy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLiczbaKolumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxKalkulatorMacierzowy;
        private System.Windows.Forms.Button bttnIloczynAB;
        private System.Windows.Forms.Button bttnBminusA;
        private System.Windows.Forms.Button bttnAminusB;
        private System.Windows.Forms.Button bttnAplusB;
        private System.Windows.Forms.GroupBox groupBoxPrzysickiOperacyjne;
        private System.Windows.Forms.Button bttnUtworzA;
        private System.Windows.Forms.Button bttnWygenerujA;
        private System.Windows.Forms.Button bttnAkceptujA;
        private System.Windows.Forms.Button bttnAkceptujB;
        private System.Windows.Forms.Button bttnWygenerujB;
        private System.Windows.Forms.Button bttnUtworzB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.GroupBox groupBoxIlośćliczb;
        private System.Windows.Forms.RadioButton radioButtonDwieLiczby;
        private System.Windows.Forms.RadioButton radioButtonJednaLiczba;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.GroupBox groupBoxLiczbaA;
        private System.Windows.Forms.TextBox txtIm1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRe1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxLiczbaB;
        private System.Windows.Forms.TextBox txtIm2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRe2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxKalkulator;
        private System.Windows.Forms.Button bttnZ_A_plus_B;
        private System.Windows.Forms.Button bttnZ_A_iloczyn_B;
        private System.Windows.Forms.Button bttnZ_A_minus_B;
        private System.Windows.Forms.Button bttn_Z_A_dzielic_B;
        private System.Windows.Forms.Button bttnZ_sprzezona_A;
        private System.Windows.Forms.Button bttnZ_modulA;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.TextBox txtWynik;
        private System.Windows.Forms.Label label8;
    }
}

