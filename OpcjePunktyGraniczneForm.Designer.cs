
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPharameters = new System.Windows.Forms.TextBox();
            this.cboEquals = new System.Windows.Forms.ComboBox();
            this.cboTypeValue = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpLayers = new System.Windows.Forms.GroupBox();
            this.txtNameOfNewLayer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkNewLayer = new System.Windows.Forms.CheckBox();
            this.cboLayers = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rbnSelect = new System.Windows.Forms.RadioButton();
            this.rbnSaveToLayer = new System.Windows.Forms.RadioButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtPharameters2 = new System.Windows.Forms.TextBox();
            this.cboEquals2 = new System.Windows.Forms.ComboBox();
            this.cboTypeValue2 = new System.Windows.Forms.ComboBox();
            this.rbnMove = new System.Windows.Forms.RadioButton();
            this.rbnCopy = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpLayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(24, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry wyboru:";
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
            this.groupBox2.Location = new System.Drawing.Point(24, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametry wyników";
            // 
            // grpLayers
            // 
            this.grpLayers.Controls.Add(this.rbnCopy);
            this.grpLayers.Controls.Add(this.rbnMove);
            this.grpLayers.Controls.Add(this.txtNameOfNewLayer);
            this.grpLayers.Controls.Add(this.label5);
            this.grpLayers.Controls.Add(this.chkNewLayer);
            this.grpLayers.Controls.Add(this.cboLayers);
            this.grpLayers.Location = new System.Drawing.Point(24, 261);
            this.grpLayers.Name = "grpLayers";
            this.grpLayers.Size = new System.Drawing.Size(344, 100);
            this.grpLayers.TabIndex = 3;
            this.grpLayers.TabStop = false;
            this.grpLayers.Text = "Warstwa:";
            this.grpLayers.Visible = false;
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
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(293, 232);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Wykonaj";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(27, 232);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(64, 13);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "informacje...";
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
            // OpcjePunktyGraniczneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 399);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpLayers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "OpcjePunktyGraniczneForm";
            this.Text = "OpcjePunktyGraniczneForm";
            this.Load += new System.EventHandler(this.OpcjePunktyGraniczneForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpLayers.ResumeLayout(false);
            this.grpLayers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPharameters;
        private System.Windows.Forms.ComboBox cboEquals;
        private System.Windows.Forms.ComboBox cboTypeValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpLayers;
        private System.Windows.Forms.TextBox txtNameOfNewLayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkNewLayer;
        private System.Windows.Forms.ComboBox cboLayers;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbnSaveToLayer;
        private System.Windows.Forms.RadioButton rbnSelect;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtPharameters2;
        private System.Windows.Forms.ComboBox cboEquals2;
        private System.Windows.Forms.ComboBox cboTypeValue2;
        private System.Windows.Forms.RadioButton rbnCopy;
        private System.Windows.Forms.RadioButton rbnMove;
    }
}