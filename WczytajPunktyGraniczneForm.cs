using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamianAutoCAD
{
    public partial class WczytajPunktyGraniczneForm : Form
    {
        public WczytajPunktyGraniczneForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new OpenFileDialog())
            {
                fbd.Filter = "Pliki .txt(*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                fbd.FilterIndex = 2;
                fbd.RestoreDirectory = true;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtFile.Text = fbd.FileName;
                }
            }
        }

        private void WczytajPunktyGraniczneForm_Load(object sender, EventArgs e)
        {
            cboNr.SelectedIndex = 0;
            cboX.SelectedIndex = 1;
            cboY.SelectedIndex = 2;
            cboBPP.SelectedIndex = 3;
            cboSTB.SelectedIndex = 4;
            cboZRD.SelectedIndex = 5;
            cboRZG.SelectedIndex = 6;

            List<string> warstwy = new List<string>();
            PozyskanieInformacjiDWG Info = new PozyskanieInformacjiDWG();
            warstwy = Info.ListaWarstw();
            foreach (string item in warstwy)
            {
                cboWarstwy.Items.Add(item);
            }
            cboWarstwy.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //zmienna na próbna wysokosc i wartosc tekstu...
            double wys;
            string wartosc;
            wartosc = txtTextHeight.Text.Replace(",", ".");


            bool CzyText = double.TryParse(wartosc, out wys);
            if (!CzyText)
            {
                Message(lblInfo.Text = "Wpisano błędną wysokość tektu!",Color.Red);
                btnWczytaj.Enabled = false;

            }
            else
            {
                Message("Wpisano prawidłową wysokość tekstu!",Color.Black);
                btnWczytaj.Enabled = true;
            }

        }

        private async void btnWczytaj_Click(object sender, EventArgs e)
        {
                string NazwaPliku = txtFile.Text.Trim();
                string[] LiniePliku;
                try {
                    LiniePliku = System.IO.File.ReadAllLines(NazwaPliku);
                } catch (Exception ex) {
                    Message("Błąd podczas wczytywania pliku: " + ex.Message, Color.Red);
                    return;
                }

                //Określ separator w pliku
                string Separator = "";

                if (rbnSrednik.Checked) Separator = ";";
                else if (rbnPrzecinek.Checked) Separator = ",";
                else if (rbnSpacja.Checked) Separator = " ";
                else if (rbnTab.Checked) Separator = Convert.ToString(Convert.ToChar(9));
                else if (rbnInne.Checked) Separator = txtInnySeparator.Text;
                else {
                    Message("Nie wybrano separatora!.", Color.Red);
                    return;
                }

                //Określ warstwe na którą mają zostać wczytane punkty
                string warstwa = cboWarstwy.Text;

                //Sprawdz nazwe pliku...
                string plik = "";
                if (chkInsertFileName.Checked) {
                    plik = txtFile.Text.Substring(txtFile.Text.LastIndexOf("\\") + 1);
                }

                //Sprawdzenie poprawnosci separatora...
                try {
                    string[] Ele = LiniePliku[1].Split(Separator.ToCharArray(), System.StringSplitOptions.None);
                    double Test = Convert.ToDouble(Ele[int.Parse(cboX.Text)].Replace(',', '.'));
                } catch (Exception) {
                    Message("Wybrano niepoprawny separator! Sprawdź plik.", Color.Red);
                    return;
                }
                //Stworzenie Mapy właściwości dla punktu...
                Dictionary<string, string> DaneWPliku = new Dictionary<string, string>();
                DaneWPliku.Add("ID", "");
                DaneWPliku.Add("X", "");
                DaneWPliku.Add("Y", "");
                DaneWPliku.Add("BPP", "");
                DaneWPliku.Add("STB", "");
                DaneWPliku.Add("ZRD", "");
                DaneWPliku.Add("RZG", "");
                DaneWPliku.Add("PLIK", plik);
                DaneWPliku.Add("Layer", cboWarstwy.Text);
                DaneWPliku.Add("TextHeight", txtTextHeight.Text);

                PunktyGraniczne wpg = new PunktyGraniczne();
                int kol;
                int i = 1;
                bool first = true;
                foreach (string linie in LiniePliku) {
                    if (first) {
                        first = false;
                        if (chkSkipFirst.Checked)
                            continue;
                    }
                    string[] elem = linie.Split(Separator.ToCharArray(), System.StringSplitOptions.None);
                    //próba odczytania danych...
                    try {
                        kol = Int32.Parse(cboNr.Text);
                        DaneWPliku["ID"] = elem[kol - 1];

                        kol = Int32.Parse(cboX.Text);
                        DaneWPliku["X"] = elem[kol - 1];

                        kol = Int32.Parse(cboY.Text);
                        DaneWPliku["Y"] = elem[kol - 1];

                        //BPP..........
                        if (cboBPP.Text != "brak") {
                            kol = Int32.Parse(cboBPP.Text);
                            DaneWPliku["BPP"] = elem[kol - 1];
                        } else {
                            DaneWPliku["BPP"] = "";
                        }

                        //STB.............
                        if (cboSTB.Text != "brak") {
                            kol = Int32.Parse(cboSTB.Text);
                            DaneWPliku["STB"] = elem[kol - 1];
                        } else {
                            DaneWPliku["STB"] = "";
                        }


                        //ZRD..........
                        if (cboZRD.Text != "brak") {
                            kol = Int32.Parse(cboZRD.Text);
                            DaneWPliku["ZRD"] = elem[kol - 1];
                        } else {
                            DaneWPliku["ZRD"] = "";
                        }

                        //RZG............
                        if (cboRZG.Text != "brak") {
                            kol = Int32.Parse(cboRZG.Text);
                            DaneWPliku["RZG"] = elem[kol - 1];
                        } else {
                            DaneWPliku["RZG"] = "";
                        }

                        wpg.AddBlockWithAttributes(DaneWPliku);


                    } catch (Exception ex) {
                        Message("Błąd w linii: " + i.ToString() + "Treść: " + ex.Message, Color.Red);
                        return;
                    }
                    i++;
                    Iteracja(i, LiniePliku.Length);
                }
                    Message("Wczytano pomyślnie: " + i.ToString() + " punktów.", Color.Green);
        }

        private void Iteracja(long i, long j) {
            this.Invoke(new Action(() => {
                lblInfo.Text = $"Wczytano {i} z {j}";
                Application.DoEvents();
            }));
        }
        private void Message(string text, Color c) {
            this.Invoke(new Action(() => {
                lblInfo.Text = text;
                lblInfo.ForeColor = c;
            }));
        
        }
    }
}
