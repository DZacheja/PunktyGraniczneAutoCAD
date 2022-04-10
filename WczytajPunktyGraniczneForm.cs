/*
 * Okno do wyboru parametrow wczytywanych punktów granicznych
 * autor: Damian Zacheja
 * 
 * 
 */
using DZacheja_PunktyGraniczne;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamianAutoCAD {
    public partial class WczytajPunktyGraniczneForm : Form {
        public WczytajPunktyGraniczneForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Wskazanie wczytywanego pliku
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e) {
            using (var fbd = new OpenFileDialog()) {
                fbd.Filter = "Pliki .txt(*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                fbd.FilterIndex = 2;
                fbd.RestoreDirectory = true;
                if (fbd.ShowDialog() == DialogResult.OK) {
                    txtFile.Text = fbd.FileName;
                }
            }
        }

        /// <summary>
        /// Ustawienie domyślnych parametrów okna po załadowaniu formularza
        /// </summary>
        private void WczytajPunktyGraniczneForm_Load(object sender, EventArgs e) {
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
            foreach (string item in warstwy) {
                cboWarstwy.Items.Add(item);
            }
            cboWarstwy.SelectedIndex = 0;
        }

        /// <summary>
        /// Walidacja poprawności wprowadzania wysokości tekstu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTextHeight_TextChanged(object sender, EventArgs e) {
            //zmienna na próbna wysokosc i wartosc tekstu...
            double wys;
            string wartosc;
            wartosc = txtTextHeight.Text.Replace(",", ".");


            bool CzyText = double.TryParse(wartosc, out wys);
            if (!CzyText) {
                Message(lblInfo.Text = "Wpisano błędną wysokość tektu!", Color.Red);
                btnWczytaj.Enabled = false;

            } else {
                Message("Wpisano prawidłową wysokość tekstu!", Color.Black);
                btnWczytaj.Enabled = true;
            }

        }

        /// <summary>
        /// Wczytanie punktów asynchronicznie
        /// </summary>
        private async void btnWczytaj_Click(object sender, EventArgs e) {
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
            PunktGraniczny pkt = new PunktGraniczny();
            pkt.layer = cboWarstwy.Text;
            pkt.txtHeight = Convert.ToDouble(txtTextHeight.Text);
            if (chkInsertFileName.Checked) {
                pkt.plik = Path.GetFileName(txtFile.Text);
            } else {
                pkt.plik = "";
            }
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
                    pkt.ID = elem[kol - 1];

                    kol = Int32.Parse(cboX.Text);
                    pkt.X = Convert.ToDouble(elem[kol - 1].Replace(',','.'));

                    kol = Int32.Parse(cboY.Text);
                    pkt.Y = Convert.ToDouble(elem[kol - 1].Replace(',', '.'));

                    //BPP..........
                    if (cboBPP.Text != "brak") {
                        kol = Int32.Parse(cboBPP.Text);
                        pkt.BPP = elem[kol - 1];
                    } else {
                        pkt.BPP = "";
                    }

                    //STB.............
                    if (cboSTB.Text != "brak") {
                        kol = Int32.Parse(cboSTB.Text);
                        pkt.STB = elem[kol - 1];
                    } else {
                        pkt.STB = "";
                    }


                    //ZRD..........
                    if (cboZRD.Text != "brak") {
                        kol = Int32.Parse(cboZRD.Text);
                        pkt.ZRD = elem[kol - 1];
                    } else {
                        pkt.ZRD = "";
                    }

                    //RZG............
                    if (cboRZG.Text != "brak") {
                        kol = Int32.Parse(cboRZG.Text);
                        pkt.RZG = elem[kol - 1];
                    } else {
                        pkt.RZG = "";
                    }

                    wpg.AddBlockWithAttributes(pkt);


                } catch (Exception ex) {
                    Message("Błąd w linii: " + i.ToString() + "Treść: " + ex.Message, Color.Red);
                    return;
                }
                i++;
                Iteracja(i, LiniePliku.Length);
            }
            Message("Wczytano pomyślnie: " + i.ToString() + " punktów.", Color.Green);
        }

        /// <summary>
        /// Zmiana popdpisu labelinfo odnoście wczytywanego punktu
        /// </summary>
        /// <param name="i">obecny numer punktu</param>
        /// <param name="j">liczba wszystkich punktów</param>
        private void Iteracja(long i, long j) {
            this.Invoke(new Action(() => {
                lblInfo.Text = $"Wczytano {i} z {j}";
                Application.DoEvents();
            }));
        }

        /// <summary>
        /// Wpisanie wiadomości do lblInfo
        /// </summary>
        /// <param name="text">treść informacji</param>
        /// <param name="c">kolor tekstu</param>
        private void Message(string text, Color c) {
            this.Invoke(new Action(() => {
                lblInfo.Text = text;
                lblInfo.ForeColor = c;
            }));

        }
    }
}
