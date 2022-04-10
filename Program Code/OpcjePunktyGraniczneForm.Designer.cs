
namespace DamianAutoCAD
{
    partial class OpcjePunktyGraniczneForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPharameters2 = new System.Windows.Forms.TextBox();
            this.cboEquals2 = new System.Windows.Forms.ComboBox();
            this.cboTypeValue2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPharameters = new System.Windows.Forms.TextBox();
            this.cboEquals = new System.Windows.Forms.ComboBox();
            this.cboTypeValue = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnSaveToLayer = new System.Windows.Forms.RadioButton();
            this.rbnSelect = new System.Windows.Forms.RadioButton();
            this.grpLayers = new System.Windows.Forms.GroupBox();
            this.rbnCopy = new System.Windows.Forms.RadioButton();
            this.rbnMove = new System.Windows.Forms.RadioButton();
            this.txtNameOfNewLayer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkNewLayer = new System.Windows.Forms.CheckBox();
            this.cboLayers = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpLayers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.grpLayers);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 406);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operacje na punktach granicznych";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPharameters2);
            this.groupBox1.Controls.Add(this.cboEquals2);
            this.groupBox1.Controls.Add(this.cboTypeValue2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPharameters);
            this.groupBox1.Controls.Add(this.cboEquals);
            this.groupBox1.Controls.Add(this.cboTypeValue);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 107);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry wyboru:";
            // 
            // txtPharameters2
            // 
            this.txtPharameters2.Location = new System.Drawing.Point(195, 73);
            this.txtPharameters2.Name = "txtPharameters2";
            this.txtPharameters2.Size = new System.Drawing.Size(123, 20);
            this.txtPharameters2.TabIndex = 8;
            // 
            // cboEquals2
            // 
            this.cboEquals2.FormattingEnabled = true;
            this.cboEquals2.Items.AddRange(new object[] {
            "",
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "<>"});
            this.cboEquals2.Location = new System.Drawing.Point(113, 73);
            this.cboEquals2.Name = "cboEquals2";
            this.cboEquals2.Size = new System.Drawing.Size(60, 21);
            this.cboEquals2.TabIndex = 7;
            // 
            // cboTypeValue2
            // 
            this.cboTypeValue2.FormattingEnabled = true;
            this.cboTypeValue2.Items.AddRange(new object[] {
            "",
            "Numer",
            "BPP",
            "STB",
            "ZRD",
            "RZG",
            "Plik"});
            this.cboTypeValue2.Location = new System.Drawing.Point(6, 73);
            this.cboTypeValue2.Name = "cboTypeValue2";
            this.cboTypeValue2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboTypeValue2.Size = new System.Drawing.Size(87, 21);
            this.cboTypeValue2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wartość:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Równianie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Atrybut:";
            // 
            // txtPharameters
            // 
            this.txtPharameters.Location = new System.Drawing.Point(195, 46);
            this.txtPharameters.Name = "txtPharameters";
            this.txtPharameters.Size = new System.Drawing.Size(123, 20);
            this.txtPharameters.TabIndex = 2;
            // 
            // cboEquals
            // 
            this.cboEquals.FormattingEnabled = true;
            this.cboEquals.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "<>"});
            this.cboEquals.Location = new System.Drawing.Point(113, 46);
            this.cboEquals.Name = "cboEquals";
            this.cboEquals.Size = new System.Drawing.Size(60, 21);
            this.cboEquals.TabIndex = 1;
            // 
            // cboTypeValue
            // 
            this.cboTypeValue.FormattingEnabled = true;
            this.cboTypeValue.Items.AddRange(new object[] {
            "Numer",
            "BPP",
            "STB",
            "ZRD",
            "RZG",
            "Plik"});
            this.cboTypeValue.Location = new System.Drawing.Point(6, 46);
            this.cboTypeValue.Name = "cboTypeValue";
            this.cboTypeValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboTypeValue.Size = new System.Drawing.Size(87, 21);
            this.cboTypeValue.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnSaveToLayer);
            this.groupBox2.Controls.Add(this.rbnSelect);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 67);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametry wyników";
            // 
            // rbnSaveToLayer
            // 
            this.rbnSaveToLayer.AutoSize = true;
            this.rbnSaveToLayer.Location = new System.Drawing.Point(116, 30);
            this.rbnSaveToLayer.Name = "rbnSaveToLayer";
            this.rbnSaveToLayer.Size = new System.Drawing.Size(112, 17);
            this.rbnSaveToLayer.TabIndex = 1;
            this.rbnSaveToLayer.TabStop = true;
            this.rbnSaveToLayer.Text = "Zapisz do warstwy";
            this.rbnSaveToLayer.UseVisualStyleBackColor = true;
            this.rbnSaveToLayer.CheckedChanged += new System.EventHandler(this.rbnSaveToLayer_CheckedChanged);
            // 
            // rbnSelect
            // 
            this.rbnSelect.AutoSize = true;
            this.rbnSelect.Location = new System.Drawing.Point(10, 30);
            this.rbnSelect.Name = "rbnSelect";
            this.rbnSelect.Size = new System.Drawing.Size(66, 17);
            this.rbnSelect.TabIndex = 0;
            this.rbnSelect.TabStop = true;
            this.rbnSelect.Text = "Zaznacz";
            this.rbnSelect.UseVisualStyleBackColor = true;
            this.rbnSelect.CheckedChanged += new System.EventHandler(this.rbnSelect_CheckedChanged);
            // 
            // grpLayers
            // 
            this.grpLayers.Controls.Add(this.rbnCopy);
            this.grpLayers.Controls.Add(this.rbnMove);
            this.grpLayers.Controls.Add(this.txtNameOfNewLayer);
            this.grpLayers.Controls.Add(this.label5);
            this.grpLayers.Controls.Add(this.chkNewLayer);
            this.grpLayers.Controls.Add(this.cboLayers);
            this.grpLayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpLayers.Location = new System.Drawing.Point(0, 198);
            this.grpLayers.Name = "grpLayers";
            this.grpLayers.Size = new System.Drawing.Size(432, 100);
            this.grpLayers.TabIndex = 15;
            this.grpLayers.TabStop = false;
            this.grpLayers.Text = "Warstwa:";
            this.grpLayers.Visible = false;
            // 
            // rbnCopy
            // 
            this.rbnCopy.AutoSize = true;
            this.rbnCopy.Location = new System.Drawing.Point(231, 46);
            this.rbnCopy.Name = "rbnCopy";
            this.rbnCopy.Size = new System.Drawing.Size(53, 17);
            this.rbnCopy.TabIndex = 5;
            this.rbnCopy.TabStop = true;
            this.rbnCopy.Text = "kopiuj";
            this.rbnCopy.UseVisualStyleBackColor = true;
            // 
            // rbnMove
            // 
            this.rbnMove.AutoSize = true;
            this.rbnMove.Location = new System.Drawing.Point(160, 46);
            this.rbnMove.Name = "rbnMove";
            this.rbnMove.Size = new System.Drawing.Size(64, 17);
            this.rbnMove.TabIndex = 4;
            this.rbnMove.TabStop = true;
            this.rbnMove.Text = "przenieś";
            this.rbnMove.UseVisualStyleBackColor = true;
            // 
            // txtNameOfNewLayer
            // 
            this.txtNameOfNewLayer.Location = new System.Drawing.Point(132, 69);
            this.txtNameOfNewLayer.Name = "txtNameOfNewLayer";
            this.txtNameOfNewLayer.Size = new System.Drawing.Size(186, 20);
            this.txtNameOfNewLayer.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nazwa nowej warstwy:";
            // 
            // chkNewLayer
            // 
            this.chkNewLayer.AutoSize = true;
            this.chkNewLayer.Location = new System.Drawing.Point(10, 48);
            this.chkNewLayer.Name = "chkNewLayer";
            this.chkNewLayer.Size = new System.Drawing.Size(143, 17);
            this.chkNewLayer.TabIndex = 1;
            this.chkNewLayer.Text = "Zapisz na nową warstwę";
            this.chkNewLayer.UseVisualStyleBackColor = true;
            // 
            // cboLayers
            // 
            this.cboLayers.FormattingEnabled = true;
            this.cboLayers.Location = new System.Drawing.Point(10, 20);
            this.cboLayers.Name = "cboLayers";
            this.cboLayers.Size = new System.Drawing.Size(308, 21);
            this.cboLayers.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 54);
            this.panel1.TabIndex = 16;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 32);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(64, 13);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "informacje...";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(311, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Wykonaj";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // OpcjePunktyGraniczneForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(432, 406);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "OpcjePunktyGraniczneForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "OpcjePunktyGraniczneForm";
            this.Load += new System.EventHandler(this.OpcjePunktyGraniczneForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpLayers.ResumeLayout(false);
            this.grpLayers.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpLayers;
        private System.Windows.Forms.RadioButton rbnCopy;
        private System.Windows.Forms.RadioButton rbnMove;
        private System.Windows.Forms.TextBox txtNameOfNewLayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkNewLayer;
        private System.Windows.Forms.ComboBox cboLayers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnSaveToLayer;
        private System.Windows.Forms.RadioButton rbnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPharameters2;
        private System.Windows.Forms.ComboBox cboEquals2;
        private System.Windows.Forms.ComboBox cboTypeValue2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPharameters;
        private System.Windows.Forms.ComboBox cboEquals;
        private System.Windows.Forms.ComboBox cboTypeValue;
        private System.Windows.Forms.Label label1;
    }
}