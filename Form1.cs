using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektnr1_Chalyi_59022
{

    public partial class Projekt1 : Form
    {   
        //pomocnicze deklaracje stalych
        const ushort scOdstęp = 10;
        const ushort scSzerokośćKolumny = 70;
        const ushort scWysokośćWiersza = 25;
        const int scDolnaGranicaPrzedziału = 10;
        const int scGórnaGranicaPrzedziału = 100;
        const double scDolnaGranicaPrzedziałuDouble = 200.0;
        const double scGórnaGranicaPrzediałuDouble = 800.0;
        /*deklaracja tablicy zespoleń otwarcia stron (kart) kkontenera*/
        bool[] scStanStronZakładki = { true, false, false };
        //deklaracje macierzy
        Macierz scA;
        Macierz scB;
        Macierz scC;
        //deklaracja zmiennych referencyjnych
        DataGridView scdgvMaciezA;
        DataGridView scdgvMaciezB;
        DataGridView scdgvMaciezC;
        //deklaracja liczb zespolonych
        LiczbaZespolona scLiczbaA;
        LiczbaZespolona scLiczbaB;
        LiczbaZespolona scLiczbaZ;


        public Projekt1()
        {
            InitializeComponent();
        }

        private void Zakładki_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //indefikacja wybranej strony kontenera
            if (e.TabPage == Zakładki.TabPages[0])
                if (scStanStronZakładki[0])
                {
                    e.Cancel = false;
                    Zakładki.SelectedTab = tabPageKokpit;
                }
                else e.Cancel = true;
            else
                if (e.TabPage == Zakładki.TabPages[1])
                if (scStanStronZakładki[1])
                {
                    e.Cancel = false;
                    Zakładki.SelectedTab = tabPageMacieze;
                }
                else e.Cancel = true;
            else
                if (e.TabPage == Zakładki.TabPages[2])
                if (scStanStronZakładki[2])
                {
                    e.Cancel = false;
                    Zakładki.SelectedTab = tabPageZespolone;
                }
                else e.Cancel = true;
        }

        private void bttn_Macierze_Click(object sender, EventArgs e)
        {
            //zablokowanie przejścia do strony Kokpit
            scStanStronZakładki[0] = false;
            //zezwolenie na przejścia do strony Dzialanie na Macierzach
            scStanStronZakładki[1] = true;
            //realizacja przejścia do strony Dzialanie na Macierzach
            Zakładki.SelectedIndex = 1;
        }

        private void bttn_Zespolone_Click(object sender, EventArgs e)
        {
            //zablokowanie przejścia do strony Kokpit
            scStanStronZakładki[0] = false;
            //zezwolenie na przejścia do strony Dzialanie na liczbach zespolonych
            scStanStronZakładki[2] = true;
            //realizacja przejścia do Dzialanie na liczbach zespolonych
            Zakładki.SelectedIndex = 2;
        }

        private void bttn_return_z_Macierze_Click(object sender, EventArgs e)
        {
            //zablokowanie przejścia do strony Dzialanie na Macierzach
            scStanStronZakładki[1] = false;
            //zezwolenie na przejścia do strony Kokpit
            scStanStronZakładki[0] = true;
            //realizacja przejścia do strony Kokpit
            Zakładki.SelectedTab = tabPageKokpit;
        }

        private void bttn_return_z_Zespolonych_Click(object sender, EventArgs e)
        {
            //zablokowanie przejścia do strony Dzialanie na liczbach zespolonych
            scStanStronZakładki[2] = false;
            //zezwolenie na przejścia do strony Kokpit
            scStanStronZakładki[0] = true;
            //realizacja przejścia do strony Kokpit
            Zakładki.SelectedTab = tabPageKokpit;
        }

        private void bttnUtworzA_Click(object sender, EventArgs e)
        {
            //deklaracje lokalne
            ushort scLiczbaWierzyMacierzy;
            ushort scLiczbaKolumnMacierzy;
            //zgaszenie kontrolki errorProvider1
            errorProvider1.Dispose();
            //pobranie liczy wierzy
            if (!ushort.TryParse(txtBoxLiczbaWierzy.Text, out scLiczbaWierzyMacierzy))
            {
                errorProvider1.SetError(txtBoxLiczbaWierzy, "ERROR: wystąpił niedozwolony znak w zapisie liczby wierszy macierzy");
                return;
            }
            //pobranie liczby kolumn
            if (!ushort.TryParse(txtBoxLiczbaKolumn.Text, out scLiczbaKolumnMacierzy))
            {
                errorProvider2.SetError(txtBoxLiczbaKolumn, "ERROR: wystąpił niedozwolony znak w zapisie liczby wierszy macierzy");
                return;
            }
            //utworzenie egzemplarza klasy DataGridView
            scdgvMaciezA = new DataGridView();
            //określenie lokalizacji i rozmiarów dgvMacierzA
            scdgvMaciezA.Location = new Point(groupBoxOpisRozmiaruMacierzy.Location.X + groupBoxOpisRozmiaruMacierzy.Width + scOdstęp,
                bttn_return_z_Macierze.Top);
            scdgvMaciezA.Size = new Size((scLiczbaKolumnMacierzy + 1) * scSzerokośćKolumny,
                (scLiczbaWierzyMacierzy + 1) * scWysokośćWiersza);
            //przypisanie kontrolce dgvMacierzA liczby kolumn
            scdgvMaciezA.ColumnCount = scLiczbaKolumnMacierzy;
            //odsłonięcie wierza nagłówkowego (HEADER) dla kolumn
            scdgvMaciezA.ColumnHeadersVisible = true;
            //zezwolenie na odczytywanie i wpisanie wartości elementów kontrolki DataGridView
            scdgvMaciezA.ReadOnly = false;
            //uniemożliwienia dodawania nowych wierszy do kontrolki DataGridView
            scdgvMaciezA.AllowUserToAddRows = false;
            //ustanawenie trybu AutoSize dla nadłówka kolumn kontrolki DataGridView
            scdgvMaciezA.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //uniemożliwenie selekcji wielu komórek kontroli DataGridView
            scdgvMaciezA.MultiSelect = false;
            //sformatowanie opisu nagłówka (HEADERa) kolumn kontrolki DataGridView
            DataGridViewCellStyle scStylHeaderKolumny = new DataGridViewCellStyle();
            scStylHeaderKolumny.Font = new Font("Arial", 10, FontStyle.Bold);
            scStylHeaderKolumny.Alignment = DataGridViewContentAlignment.MiddleCenter;
            scStylHeaderKolumny.Format = "  ";
            //przypiseine egzemplarza styłu nagłówka kolumn do kontrolki dgvMacierzA
            scdgvMaciezA.ColumnHeadersDefaultCellStyle = scStylHeaderKolumny;
            //sformatowanie opisu nagłówka werszy do kontrolki dgvMacierz A
            DataGridViewCellStyle scStylHeaderWiersza = new DataGridViewCellStyle();
            scStylHeaderWiersza.Font = new Font("Arial", 10, FontStyle.Bold);
            scStylHeaderWiersza.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //przypisanie egzemplarza stylu nagłówka wierszy do kontrolki DataGridView
            scdgvMaciezA.RowHeadersDefaultCellStyle = scStylHeaderWiersza;
            //wpisanie numerów kolumn w dgvMacierzA
            for (ushort sci = 0; sci < scLiczbaKolumnMacierzy; sci++)
            {
                //wpisanie numeru kolumny
                scdgvMaciezA.Columns[sci].HeaderText = "(" + sci + ")";
                scdgvMaciezA.Columns[sci].Width = scSzerokośćKolumny;
                //wycentrowanie zapisu w kolumnie
                scdgvMaciezA.Columns[sci].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
            //dodanie wierszy
            for (ushort sci = 0; sci < scLiczbaWierzyMacierzy; sci++)
                scdgvMaciezA.Rows.Add();
            //wpisanie numerów wierszzy
            for (ushort sci = 0; sci < scLiczbaWierzyMacierzy; sci++)
                scdgvMaciezA.Rows[sci].HeaderCell.Value = "(" + sci + ")";
            //dodanie egzemplarza
            Zakładki.TabPages[1].Controls.Add(scdgvMaciezA);
            //ustanawenie AutoResize dla naglówków kontrolki dgv
            scdgvMaciezA.AutoResizeRowHeadersWidth
                (DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            scdgvMaciezA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //ustanawenie stanu braku aktywności
            bttnUtworzA.Enabled = false;
            //uaktywnenie nsatępnych przycisków poleceń
            bttnWygenerujA.Enabled = true;
            bttnAkceptujA.Enabled = true;
            bttnUtworzB.Enabled = true;
        }

        private void bttnWygenerujA_Click(object sender, EventArgs e)
        {
            Random scrnd = new Random();
            for (ushort sci = 0; sci < scdgvMaciezA.Rows.Count; sci++)
                for (ushort scj = 0; scj < scdgvMaciezA.Columns.Count; scj++)
                    scdgvMaciezA.Rows[sci].Cells[scj].Value =
                        scrnd.Next(scDolnaGranicaPrzedziału, scGórnaGranicaPrzedziału);
            //ustanawenia braku aktywności poleceń
            bttnWygenerujA.Enabled = false;
        }

        private void bttnAkceptujA_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            for (ushort sci = 0; sci < scdgvMaciezA.Rows.Count; sci++)
                for (ushort scj = 0; scj < scdgvMaciezA.Columns.Count; scj++)
                    if (scdgvMaciezA.Rows[sci].Cells[scj].Value is null)
                    {
                        MessageBox.Show("scdgvMaciezA.Rows[sci].Cells[scj].Value is null");
                        errorProvider1.SetError(bttnAkceptujA, "ERROR:wszystkie komórki kontrolki DataGridView dla" +
                            "macierzy A muszą byćwypełnione wartościami jej elementów");
                        return;
                    }
            //ustanawenia rozmiarów macierzy
            scA = new Macierz((ushort)scdgvMaciezA.Rows.Count,(ushort)scdgvMaciezA.Columns.Count);
            //przepisywanie wartościej z dgv do macierzy
            scA.PrzepiszElementyDataGridViewDoMacierzy(scdgvMaciezA);
            //ustawić tryb ReadOnly
            scdgvMaciezA.ReadOnly = true;
            bttnAkceptujA.Enabled = false;
            //stan aktywności dla przyciskow kalkulatorza
            groupBoxKalkulatorMacierzowy.Enabled = true;
        }

        private void bttnUtworzB_Click(object sender, EventArgs e)
        {
            //deklaracje lokalne
            ushort scLiczbaWierzyMacierzy;
            ushort scLiczbaKolumnMacierzy;
            //zgaszenie kontrolki errorProvider1
            errorProvider1.Dispose();
            //pobranie liczy wierzy
            if (!ushort.TryParse(txtBoxLiczbaWierzy.Text, out scLiczbaWierzyMacierzy))
            {
                errorProvider1.SetError(txtBoxLiczbaWierzy, "ERROR: wystąpił niedozwolony znak w zapisie liczby wierszy macierzy");
                return;
            }
            //pobranie liczby kolumn
            if (!ushort.TryParse(txtBoxLiczbaKolumn.Text, out scLiczbaKolumnMacierzy))
            {
                errorProvider2.SetError(txtBoxLiczbaKolumn, "ERROR: wystąpił niedozwolony znak w zapisie liczby wierszy macierzy");
                return;
            }
            //utworzenie egzemplarza klasy DataGridView
            scdgvMaciezB = new DataGridView();
            //określenie lokalizacji i rozmiarów dgvMacierzA
            scdgvMaciezB.Location = new Point(groupBoxOpisRozmiaruMacierzy.Location.X + groupBoxOpisRozmiaruMacierzy.Width + scOdstęp,
               bttnAkceptujA.Location.Y);
            scdgvMaciezB.Size = new Size((scLiczbaKolumnMacierzy + 1) * scSzerokośćKolumny,
                (scLiczbaWierzyMacierzy + 1) * scWysokośćWiersza);
            //przypisanie kontrolce dgvMacierzB liczby kolumn
            scdgvMaciezB.ColumnCount = scLiczbaKolumnMacierzy;
            //odsłonięcie wierza nagłówkowego (HEADER) dla kolumn
            scdgvMaciezB.ColumnHeadersVisible = true;
            //zezwolenie na odczytywanie i wpisanie wartości elementów kontrolki DataGridView
            scdgvMaciezB.ReadOnly = false;
            //uniemożliwienia dodawania nowych wierszy do kontrolki DataGridView
            scdgvMaciezB.AllowUserToAddRows = false;
            //ustanawenie trybu AutoSize dla nadłówka kolumn kontrolki DataGridView
            scdgvMaciezB.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //uniemożliwenie selekcji wielu komórek kontroli DataGridView
            scdgvMaciezB.MultiSelect = false;
            //sformatowanie opisu nagłówka (HEADERa) kolumn kontrolki DataGridView
            DataGridViewCellStyle scStylHeaderKolumny = new DataGridViewCellStyle();
            scStylHeaderKolumny.Font = new Font("Arial", 10, FontStyle.Bold);
            scStylHeaderKolumny.Alignment = DataGridViewContentAlignment.MiddleCenter;
            scStylHeaderKolumny.Format = "  ";
            //przypiseine egzemplarza styłu nagłówka kolumn do kontrolki dgvMacierzB
            scdgvMaciezB.ColumnHeadersDefaultCellStyle = scStylHeaderKolumny;
            //sformatowanie opisu nagłówka werszy do kontrolki dgvMacierz A
            DataGridViewCellStyle scStylHeaderWiersza = new DataGridViewCellStyle();
            scStylHeaderWiersza.Font = new Font("Arial", 10, FontStyle.Bold);
            scStylHeaderWiersza.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //przypisanie egzemplarza stylu nagłówka wierszy do kontrolki DataGridView
            scdgvMaciezB.RowHeadersDefaultCellStyle = scStylHeaderWiersza;
            //wpisanie numerów kolumn w dgvMacierz
            for (ushort sci = 0; sci < scLiczbaKolumnMacierzy; sci++)
            {
                //wpisanie numeru kolumny
                scdgvMaciezB.Columns[sci].HeaderText = "(" + sci + ")";
                scdgvMaciezB.Columns[sci].Width = scSzerokośćKolumny;
                //wycentrowanie zapisu w kolumnie
                scdgvMaciezB.Columns[sci].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
            //dodanie wierszy
            for (ushort sci = 0; sci < scLiczbaWierzyMacierzy; sci++)
                scdgvMaciezB.Rows.Add();
            //wpisanie numerów wierszzy
            for (ushort sci = 0; sci < scLiczbaWierzyMacierzy; sci++)
                scdgvMaciezB.Rows[sci].HeaderCell.Value = "(" + sci + ")";
            //dodanie egzemplarza
            Zakładki.TabPages[1].Controls.Add(scdgvMaciezB);
            //ustanawenie AutoResize dla naglówków kontrolki dgv
            scdgvMaciezB.AutoResizeRowHeadersWidth
                (DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            scdgvMaciezB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //ustanawenie stanu braku aktywności
            bttnUtworzB.Enabled = false;
            //ustanawenie stanu aktywności innych poleceń
            bttnWygenerujB.Enabled = true;
            bttnAkceptujB.Enabled = true;
        }

        private void bttnWygenerujB_Click(object sender, EventArgs e)
        {
            Random scrnd = new Random();
            for (ushort sci = 0; sci < scdgvMaciezB.Rows.Count; sci++)
                for (ushort scj = 0; scj < scdgvMaciezB.Columns.Count; scj++)
                    scdgvMaciezB.Rows[sci].Cells[scj].Value =
                        scrnd.Next((int)scDolnaGranicaPrzedziałuDouble, (int)scGórnaGranicaPrzediałuDouble);
            //ustanawenia braku aktywności poleceń
            bttnWygenerujB.Enabled = false;
        }

        private void bttnAkceptujB_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            for (ushort sci = 0; sci < scdgvMaciezA.Rows.Count; sci++)
                for (ushort scj = 0; scj < scdgvMaciezA.Columns.Count; scj++)
                    if (scdgvMaciezB.Rows[sci].Cells[scj].Value is null)
                    {
                        MessageBox.Show("scdgvMaciezB.Rows[sci].Cells[scj].Value is null");
                        errorProvider1.SetError(bttnAkceptujA, "ERROR:wszystkie komórki kontrolki DataGridView dla" +
                            "macierzy B muszą byćwypełnione wartościami jej elementów");
                        return;
                    }
            //ustanawenia rozmiarów macierzy
            scB = new Macierz((ushort)scdgvMaciezB.Rows.Count, (ushort)scdgvMaciezB.Columns.Count);
            //przepisywanie wartościej z dgv do macierzy
            scB.PrzepiszElementyDataGridViewDoMacierzy(scdgvMaciezB);
            //ustawić tryb ReadOnly
            scdgvMaciezB.ReadOnly = true;
            bttnAkceptujB.Enabled = false;
            //stan aktywności dla przyciskow kalkulatorza
            groupBoxKalkulatorMacierzowy.Enabled = true;

        }
        //metod dla utworzenia dgvMacierzC
        void UtworzDGV_C()
        {
            //deklaracje lokalne
            ushort scLiczbaWierzyMacierzy;
            ushort scLiczbaKolumnMacierzy;
            //zgaszenie kontrolki errorProvider1
            errorProvider1.Dispose();
            //pobranie liczy wierzy
            if (!ushort.TryParse(txtBoxLiczbaWierzy.Text, out scLiczbaWierzyMacierzy))
            {
                errorProvider1.SetError(txtBoxLiczbaWierzy, "ERROR: wystąpił niedozwolony znak w zapisie liczby wierszy macierzy");
                return;
            }
            //pobranie liczby kolumn
            if (!ushort.TryParse(txtBoxLiczbaKolumn.Text, out scLiczbaKolumnMacierzy))
            {
                errorProvider2.SetError(txtBoxLiczbaKolumn, "ERROR: wystąpił niedozwolony znak w zapisie liczby wierszy macierzy");
                return;
            }
            //utworzenie egzemplarza klasy DataGridView
            scdgvMaciezC = new DataGridView();
            //określenie lokalizacji i rozmiarów dgvMacierzA
            scdgvMaciezC.Location = new Point(groupBoxOpisRozmiaruMacierzy.Location.X + groupBoxOpisRozmiaruMacierzy.Width + scOdstęp,
                bttnWygenerujB.Location.Y);
            scdgvMaciezC.Size = new Size((scLiczbaKolumnMacierzy + 1) * scSzerokośćKolumny,
                (scLiczbaWierzyMacierzy + 1) * scWysokośćWiersza);
            //przypisanie kontrolce dgvMacierzA liczby kolumn
            scdgvMaciezC.ColumnCount = scLiczbaKolumnMacierzy;
            //odsłonięcie wierza nagłówkowego (HEADER) dla kolumn
            scdgvMaciezC.ColumnHeadersVisible = true;
            //zablokowanie dostępu na odczytywanie i wpisanie wartości elementów kontrolki DataGridView
            scdgvMaciezC.ReadOnly = true;
            //uniemożliwienia dodawania nowych wierszy do kontrolki DataGridView
            scdgvMaciezC.AllowUserToAddRows = false;
            //ustanawenie trybu AutoSize dla nadłówka kolumn kontrolki DataGridView
            scdgvMaciezC.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //uniemożliwenie selekcji wielu komórek kontroli DataGridView
            scdgvMaciezC.MultiSelect = false;
            //sformatowanie opisu nagłówka (HEADERa) kolumn kontrolki DataGridView
            DataGridViewCellStyle scStylHeaderKolumny = new DataGridViewCellStyle();
            scStylHeaderKolumny.Font = new Font("Arial", 10, FontStyle.Bold);
            scStylHeaderKolumny.Alignment = DataGridViewContentAlignment.MiddleCenter;
            scStylHeaderKolumny.Format = "  ";
            //przypiseine egzemplarza styłu nagłówka kolumn do kontrolki dgvMacierzA
            scdgvMaciezC.ColumnHeadersDefaultCellStyle = scStylHeaderKolumny;
            //sformatowanie opisu nagłówka werszy do kontrolki dgvMacierz A
            DataGridViewCellStyle scStylHeaderWiersza = new DataGridViewCellStyle();
            scStylHeaderWiersza.Font = new Font("Arial", 10, FontStyle.Bold);
            scStylHeaderWiersza.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //przypisanie egzemplarza stylu nagłówka wierszy do kontrolki DataGridView
            scdgvMaciezC.RowHeadersDefaultCellStyle = scStylHeaderWiersza;
            //wpisanie numerów kolumn w dgvMacierzA
            for (ushort sci = 0; sci < scLiczbaKolumnMacierzy; sci++)
            {
                //wpisanie numeru kolumny
                scdgvMaciezC.Columns[sci].HeaderText = "(" + sci + ")";
                scdgvMaciezC.Columns[sci].Width = scSzerokośćKolumny;
                //wycentrowanie zapisu w kolumnie
                scdgvMaciezC.Columns[sci].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
            //dodanie wierszy
            for (ushort sci = 0; sci < scLiczbaWierzyMacierzy; sci++)
                scdgvMaciezC.Rows.Add();
            //wpisanie numerów wierszzy
            for (ushort sci = 0; sci < scLiczbaWierzyMacierzy; sci++)
                scdgvMaciezC.Rows[sci].HeaderCell.Value = "(" + sci + ")";
            //dodanie egzemplarza
            Zakładki.TabPages[1].Controls.Add(scdgvMaciezC);
            //ustanawenie AutoResize dla naglówków kontrolki dgv
            scdgvMaciezC.AutoResizeRowHeadersWidth
                (DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            scdgvMaciezC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void bttnAplusB_Click(object sender, EventArgs e)
        {
            //zgaszenie kontrolki errorprovider3
            errorProvider3.Dispose();
            //sprawdzenie czy wszyscy macierzy są akceptowani
            if (bttnAkceptujA.Enabled == true || bttnAkceptujB.Enabled == true)
            {
                errorProvider3.SetError(bttnAplusB, "ERROR: Nie akceptowany jeden z macierzej");
                return;
            }
            if (scC is null)
            {
                //utworzenie kontrolki dgv
                UtworzDGV_C();
            }
            //ustanawenia rozmiarów macierzy
            scC = new Macierz((ushort)scdgvMaciezC.Rows.Count, (ushort)scdgvMaciezC.Columns.Count);
            //sumowanie macierzej
            scC = scA + scB;
            //przepisywanie znaczeń z macierzy do dgv
            scC.PrzepiszElementyMacierzyDoKontrolkiDataGridView(scdgvMaciezC);
            //zgaszenie kontrolki
            bttnAplusB.Enabled = false;
        }


        private void bttnAminusB_Click(object sender, EventArgs e)
        {
            //zgaszenie kontrolki errorprovider3
            errorProvider3.Dispose();
            //sprawdzenie czy wszyscy macierzy są akceptowani
            if (bttnAkceptujA.Enabled == true || bttnAkceptujB.Enabled == true)
            {
                errorProvider3.SetError(bttnAplusB, "ERROR: Nie akceptowany jeden z macierzej");
                return;
            }
            if (scC is null)
            {
                //utworzenie kontrolki dgv
                UtworzDGV_C();
            }
            //ustanawenia rozmiarów macierzy
            scC = new Macierz((ushort)scdgvMaciezC.Rows.Count, (ushort)scdgvMaciezC.Columns.Count);
            //sumowanie macierzej
            scC = scA - scB;
            //przepisywanie znaczeń z macierzy do dgv
            scC.PrzepiszElementyMacierzyDoKontrolkiDataGridView(scdgvMaciezC);
            //zgaszenie kontrolki
            bttnAminusB.Enabled = false;
        }

        private void bttnBminusA_Click(object sender, EventArgs e)
        {
            //zgaszenie kontrolki errorprovider3
            errorProvider3.Dispose();
            //sprawdzenie czy wszyscy macierzy są akceptowani
            if (bttnAkceptujA.Enabled == true || bttnAkceptujB.Enabled == true)
            {
                errorProvider3.SetError(bttnAplusB, "ERROR: Nie akceptowany jeden z macierzej");
                return;
            }
            if (scC is null)
            {
                //utworzenie kontrolki dgv
                UtworzDGV_C();
            }
            //ustanawenia rozmiarów macierzy
            scC = new Macierz((ushort)scdgvMaciezC.Rows.Count, (ushort)scdgvMaciezC.Columns.Count);
            //sumowanie macierzej
            scC = scB - scA;
            //przepisywanie znaczeń z macierzy do dgv
            scC.PrzepiszElementyMacierzyDoKontrolkiDataGridView(scdgvMaciezC);
            //zgaszenie kontrolki
            bttnBminusA.Enabled = false;
        }

        private void bttnIloczynAB_Click(object sender, EventArgs e)
        {
            //zgaszenie kontrolki errorprovider3
            errorProvider3.Dispose();
            //sprawdzenie czy wszyscy macierzy są akceptowani
            if (bttnAkceptujA.Enabled == true || bttnAkceptujB.Enabled == true)
            {
                errorProvider3.SetError(bttnAplusB, "ERROR: Nie akceptowany jeden z macierzej");
                return;
            }
            if (scC is null)
            {
                //utworzenie kontrolki dgv
                UtworzDGV_C();
            }
            //ustanawenia rozmiarów macierzy
            scC = new Macierz((ushort)scdgvMaciezC.Rows.Count, (ushort)scdgvMaciezC.Columns.Count);
            //sumowanie macierzej
            scC = scB * scA;
            //przepisywanie znaczeń z macierzy do dgv
            scC.PrzepiszElementyMacierzyDoKontrolkiDataGridView(scdgvMaciezC);
            //zgaszenie kontrolki
            bttnIloczynAB.Enabled = false;
        }

        private void groupBoxIlośćliczb_Enter(object sender, EventArgs e)
        {
    
        }

        private void radioButtonDwieLiczby_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDwieLiczby.Checked == true)
            {
                groupBoxLiczbaB.Enabled = true;
                bttnZ_A_iloczyn_B.Enabled = true;
                bttn_Z_A_dzielic_B.Enabled = true;
                bttnZ_modulA.Enabled = false;
                bttnZ_sprzezona_A.Enabled = false;
                bttnZ_A_minus_B.Enabled = true;
                bttnZ_A_plus_B.Enabled = true;
            }
        }

        private void radioButtonJednaLiczba_CheckedChanged(object sender, EventArgs e)
        {
            //zgaszenie kontrolek errorprovider
            errorProvider6.Dispose();
            errorProvider7.Dispose();
            if (radioButtonJednaLiczba.Checked == true)
            {
                groupBoxLiczbaB.Enabled = false;
                bttnZ_A_iloczyn_B.Enabled = false;
                bttn_Z_A_dzielic_B.Enabled = false;
                bttnZ_modulA.Enabled = true;
                bttnZ_sprzezona_A.Enabled = true;
                bttnZ_A_minus_B.Enabled = false;
                bttnZ_A_plus_B.Enabled = false;

            }
        }

        bool scPobieranieDaneWejścioweLiczbyZespoloneA(out double scRe, out double scIm)
        {
            scRe = scIm = 0.0;
            //sprawdzenie czy dane wejściowe jest typu f;oat
            if (!double.TryParse(txtRe1.Text, out scRe))
            {//wypisanie bledu
                if (scRe != 0.0)
                {
                    errorProvider4.SetError(txtRe1, "ERROR: w zapisie wartości Re wystąpił niedozwolony znak");
                    return false;
                }
            }
            else//zgaszenie errorprovider
                errorProvider4.Dispose();
            //sprawdzenie czy dane wejściowe jest typu f;oat
            if (!double.TryParse(txtIm1.Text, out scIm))
            {//wypisanie bledu
                if (scIm != 0.0)
                {
                    errorProvider5.SetError(txtIm1, "ERROR: w zapisie wartości Im wystąpił niedozwolony znak");
                    return false;
                }
            }
            else//zgaszenie errorprovider
                errorProvider5.Dispose();
            //zgaszenie kontrolek
            txtRe1.ReadOnly = true;
            txtIm1.ReadOnly = true;
            return true;
        }
        bool scPobieranieDaneWejścioweLiczbyZespoloneB(out double scRe, out double scIm)
        {
            scRe = scIm = 0.0;
            //sprawdzenie czy dane wejściowe jest typu f;oat
            if (!double.TryParse(txtRe2.Text, out scRe))
            {//wypisanie bledu
                if (scRe != 0.0)
                {
                    errorProvider6.SetError(txtRe2, "ERROR: w zapisie wartości Re wystąpił niedozwolony znak");
                    return false;
                }
            }
            else//zgaszenie errorprovider
                errorProvider6.Dispose();

            //sprawdzenie czy dane wejściowe jest typu f;oat
            if (!double.TryParse(txtIm2.Text, out scIm))
            {//wypisanie bledu
                if (scIm != 0.0)
                {
                    errorProvider7.SetError(txtIm1, "ERROR: w zapisie wartości Im wystąpił niedozwolony znak");
                    return false;
                }
            }
            else//zgaszenie errorprovider
                errorProvider7.Dispose();
            //zgaszenie kontrolek
            txtRe2.ReadOnly = true;
            txtIm2.ReadOnly = true;
            return true;
        }

        private void bttnZ_A_plus_B_Click(object sender, EventArgs e)
        {
            //deklracja zmiennnych
            double scReA, scReB, scImA, scImB ;
            //pobieranie danych wejściowych
            scPobieranieDaneWejścioweLiczbyZespoloneA(out scReA,out scImA);
            scPobieranieDaneWejścioweLiczbyZespoloneB(out scReB, out scImB);
            //tworzenie liczb zespołonych
            scLiczbaA = new LiczbaZespolona(scReA,scImA);
            scLiczbaB = new LiczbaZespolona(scReB, scImB);
            //działanie między liczbami
            if (radioButtonDwieLiczby.Checked == true)
                scLiczbaZ = scLiczbaA + scLiczbaB;
            
            //wyświetlenie wyników
            if (scLiczbaZ.scim >= 0)
            txtWynik.Text = Convert.ToString(scLiczbaZ.scre) + "+"+Convert.ToString(scLiczbaZ.scim) +"i";
            else
                txtWynik.Text = Convert.ToString(scLiczbaZ.scre) + Convert.ToString(scLiczbaZ.scim) + "i";

            //zgaszenie kontrolki
            bttnZ_A_plus_B.Enabled = false;
        }

        private void bttnZ_A_minus_B_Click(object sender, EventArgs e)
        {
            //deklracja zmiennnych
            double scReA, scReB, scImA, scImB;
            //pobieranie danych wejściowych
            scPobieranieDaneWejścioweLiczbyZespoloneA(out scReA, out scImA);
            scPobieranieDaneWejścioweLiczbyZespoloneB(out scReB, out scImB);
            //tworzenie liczb zespołonych
            scLiczbaA = new LiczbaZespolona(scReA, scImA);
            scLiczbaB = new LiczbaZespolona(scReB, scImB);
            //działanie między liczbami
            scLiczbaZ = scLiczbaA - scLiczbaB;
            //wyświetlenie wyników
            if (scLiczbaZ.scim >= 0)
                txtWynik.Text = Convert.ToString(scLiczbaZ.scre) + "+" + Convert.ToString(scLiczbaZ.scim) + "i";
            else
                txtWynik.Text = Convert.ToString(scLiczbaZ.scre) + Convert.ToString(scLiczbaZ.scim) + "i";
            //zgaszenie kontrolki
            bttnZ_A_minus_B.Enabled = false;
        }

        private void bttnZ_A_iloczyn_B_Click(object sender, EventArgs e)
        {
            //deklracja zmiennnych
            double scReA, scReB, scImA, scImB;
            //pobieranie danych wejściowych
            scPobieranieDaneWejścioweLiczbyZespoloneA(out scReA, out scImA);
            scPobieranieDaneWejścioweLiczbyZespoloneB(out scReB, out scImB);
            //tworzenie liczb zespołonych
            scLiczbaA = new LiczbaZespolona(scReA, scImA);
            scLiczbaB = new LiczbaZespolona(scReB, scImB);
            //działanie między liczbami
            scLiczbaZ = scLiczbaA * scLiczbaB;
            //wyświetlenie wyników
            if (scLiczbaZ.scim >= 0)
                txtWynik.Text = Convert.ToString(scLiczbaZ.scre) + "+" + Convert.ToString(scLiczbaZ.scim) + "i";
            else
                txtWynik.Text = Convert.ToString(scLiczbaZ.scre) + Convert.ToString(scLiczbaZ.scim) + "i";
            //zgaszenie kontrolki
            bttnZ_A_iloczyn_B.Enabled = false;
        }

        private void bttn_Z_A_dzielic_B_Click(object sender, EventArgs e)
        {
            //deklracja zmiennnych
            double scReA, scReB, scImA, scImB;
            //pobieranie danych wejściowych
            scPobieranieDaneWejścioweLiczbyZespoloneA(out scReA, out scImA);
            scPobieranieDaneWejścioweLiczbyZespoloneB(out scReB, out scImB);
            //tworzenie liczb zespołonych
            scLiczbaA = new LiczbaZespolona(scReA, scImA);
            scLiczbaB = new LiczbaZespolona(scReB, scImB);
            //działanie między liczbami
            double scMianownik = (scLiczbaB.scre * scLiczbaB.scre) + (scLiczbaB.scim * scLiczbaB.scim);
             
            if (scMianownik == 0)
            
                MessageBox.Show("ERROR: nie ma wyników,ponieważ mianownik równa się 0!"); 
            scLiczbaZ = scLiczbaA / scLiczbaB;
            //wyświetlenie wyników
            if (scLiczbaZ.scim >= 0)
                txtWynik.Text = String.Format("{0: 0.00}", scLiczbaZ.scre) + "+" + String.Format("{0: 0.00}", scLiczbaZ.scim) + "i";
            else
                txtWynik.Text = String.Format("{0: 0.00}", scLiczbaZ.scre) + String.Format("{0: 0.00}", scLiczbaZ.scim) + "i";
            //zgaszenie kontrolki
            bttn_Z_A_dzielic_B.Enabled = false;
        }

        private void bttnZ_modulA_Click(object sender, EventArgs e)
        {
            //deklaracja zmiennych
            double scRe, scIm, scWynik;
            //pobieranie danych wejściowych
            scPobieranieDaneWejścioweLiczbyZespoloneA(out scRe, out scIm);
            //tworzenie liczby zespolonej
            scLiczbaA = new LiczbaZespolona(scRe, scIm);
            //dzialanie z liczbą
            scWynik = !scLiczbaA;
            //wypisanie wyników
            txtWynik.Text = String.Format("{0: 0.00}", scWynik);
            //ustanawenia stanu braku aktywności kontrolki
            bttnZ_modulA.Enabled = false;
        }

        private void bttnZ_sprzezona_A_Click(object sender, EventArgs e)
        {
            //deklaracja zmiennych
            double scRe, scIm;
            //pobieranie danych wejściowych
            scPobieranieDaneWejścioweLiczbyZespoloneA(out scRe, out scIm);
            //tworzenie liczby zespolonej
            scLiczbaA = new LiczbaZespolona(scRe, scIm);
            //dzialanie z liczbą
            scLiczbaZ = ~ scLiczbaA;
            //wypisanie wyników
            if (scLiczbaZ.scim >= 0)
                txtWynik.Text = Convert.ToString(scLiczbaZ.scre) + "+" + Convert.ToString(scLiczbaZ.scim) + "i";
            else
                txtWynik.Text = Convert.ToString(scLiczbaZ.scre) + Convert.ToString(scLiczbaZ.scim) + "i"; ;
            //ustanawenia stanu braku aktywności kontrolki
            bttnZ_sprzezona_A.Enabled = false;
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {   //sczyszczenie tekstu z kontrolek TextBox
            foreach (Control scKotrolka in Zakładki.TabPages[2].Controls) 
            {
                if (scKotrolka.GetType().Name == "TextBox")
                    scKotrolka.Text = "";
            }
            foreach (Control scKotrolka in groupBoxLiczbaA.Controls)
            {
                if (scKotrolka.GetType().Name == "TextBox")
                    scKotrolka.Text = "";
            }
            foreach (Control scKotrolka in groupBoxLiczbaB.Controls)
            {
                if (scKotrolka.GetType().Name == "TextBox")
                    scKotrolka.Text = "";
            }
            //ustanawenia stanu aktywności kontrolek
            if (radioButtonJednaLiczba.Checked)
            {
                bttnZ_modulA.Enabled = true;
                bttnZ_sprzezona_A.Enabled = true;
            }
            else if (radioButtonDwieLiczby.Checked)

            {
                groupBoxLiczbaB.Enabled = true;
                bttnZ_A_iloczyn_B.Enabled = true;
                bttn_Z_A_dzielic_B.Enabled = true;
                bttnZ_A_minus_B.Enabled = true;
                bttnZ_A_plus_B.Enabled = true;
            }
            txtRe1.ReadOnly = false;
            txtIm1.ReadOnly = false;
            txtRe2.ReadOnly = false;
            txtIm2.ReadOnly = false;
        }

       
    }
    //deklaracja klasy pomocniczej, która roszerzy właściwości klasy Macierz
    static class RoszerzenieWłaśćiwościKlasyMacierz
    {
        public static void PrzepiszElementyDataGridViewDoMacierzy(this Macierz scX,
            DataGridView scdgvMacierzX)
        {
            //pobieranie wartości elementów z kontrolki DataGridView i jej wpisanie do macierzy X
            for (ushort sci = 0; sci < scX.scLiczbaWierzy; sci++)
                for (ushort scj = 0; scj < scX.scLiczbaKolumn; scj++)
                    scX[sci, scj] = float.Parse((scdgvMacierzX.Rows[sci].Cells[scj].Value.ToString()));
        }

        public static void PrzepiszElementyMacierzyDoKontrolkiDataGridView(this Macierz scX,
            DataGridView scdgvMacierzX)
        {
            //wpisanie do DataGridView elementów macierzy X
            for (ushort sci = 0; sci < scdgvMacierzX.Rows.Count; sci++)
                for (ushort scj = 0; scj < scdgvMacierzX.Columns.Count; scj++)
                    scdgvMacierzX.Rows[sci].Cells[scj].Value = string.Format("{0:F2}", scX[sci, scj]);
        }
    }
}
