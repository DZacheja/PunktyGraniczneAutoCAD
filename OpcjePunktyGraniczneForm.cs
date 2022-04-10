using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamianAutoCAD
{
    public partial class OpcjePunktyGraniczneForm : Form
    {
        public OpcjePunktyGraniczneForm()
        {
            InitializeComponent();
        }


        private void rbnSaveToLayer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnSaveToLayer.Checked)
            {
                grpLayers.Visible = true;
                this.Height = 438;
                btnStart.Location = new Point(293, 356);
            }
        }

        private void rbnSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnSelect.Checked)
            {
                grpLayers.Visible = false;
                this.Height = 291;
                btnStart.Location = new Point(293, 221);
            }
        }

        private void OpcjePunktyGraniczneForm_Load(object sender, EventArgs e)
        {
            this.Height = 291;
            List<string> warstwy = new List<string>();
            PozyskanieInformacjiDWG Info = new PozyskanieInformacjiDWG();
            warstwy = Info.ListaWarstw();
            foreach (string item in warstwy)
            {
                cboLayers.Items.Add(item);
            }
            cboLayers.SelectedIndex = 0;
            cboEquals.SelectedIndex = 0;
            cboTypeValue.SelectedIndex = 0;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PunktyGraniczne pgr = new PunktyGraniczne();
            Dictionary<string, string> wybory = new Dictionary<string, string>();
            wybory.Add("Type", cboTypeValue.Text);
            wybory.Add("Equals", cboEquals.Text);
            wybory.Add("Value", txtPharameters.Text);
            
            if(rbnSelect.Checked)
                wybory.Add("Action", "Select");
            else if(rbnSaveToLayer.Checked)
                wybory.Add("Action", "SaveToLayer");
            else
            {
                lblInfo.Text = "Nie wybrano czynności!";
                lblInfo.ForeColor = Color.Red;
                return;
            }

            if(wybory["Action"] == "SaveToLayer")
            {
                if(chkNewLayer.Checked)
                    wybory.Add("Layer", txtNameOfNewLayer.Text);
                else
                {
                    if (!string.IsNullOrEmpty(cboLayers.Text))
                    {
                        wybory.Add("Layer", cboLayers.Text);
                    }else
                    {
                        lblInfo.Text = "Nie wpisano nazwy dla nowej warstwy!";
                        lblInfo.ForeColor = Color.Red;
                        return;
                    }
                }
                if (rbnMove.Checked)
                    wybory.Add("Modify", "Move");
                else if (rbnCopy.Checked)
                    wybory.Add("Modify", "Copy");
                else
                {
                    lblInfo.Text = "Nie operacji dla znalezionyc punktów!";
                    lblInfo.ForeColor = Color.Red;
                    return;
                }
            }

            pgr.WykonajSelekcje(wybory);

            wybory["Type"] = cboTypeValue2.Text;
            wybory["Equals"] = cboEquals2.Text;
            wybory["Value"] = txtPharameters2.Text;

            if(!string.IsNullOrEmpty(cboEquals2.Text) && !string.IsNullOrEmpty(cboTypeValue2.Text))
                pgr.WykonajSelekcje(wybory);

            lblInfo.Text = "Wykonano pomyślnie!";
            lblInfo.ForeColor = Color.Green;
        }
    }
}
