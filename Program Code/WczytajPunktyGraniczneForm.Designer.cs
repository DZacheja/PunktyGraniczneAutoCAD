
namespace DamianAutoCAD
{
    partial class WczytajPunktyGraniczneForm
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSkipFirst = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtInnySeparator = new System.Windows.Forms.TextBox();
            this.rbnInne = new System.Windows.Forms.RadioButton();
            this.rbnTab = new System.Windows.Forms.RadioButton();
            this.rbnSpacja = new System.Windows.Forms.RadioButton();
            this.rbnPrzecinek = new System.Windows.Forms.RadioButton();
            this.rbnSrednik = new System.Windows.Forms.RadioButton();
            this.cboZRD = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboSTB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboBPP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboY = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboX = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRZG = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkInsertFileName = new System.Windows.Forms.CheckBox();
            this.cboWarstwy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTextHeight = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wczytywanie Punktów Granicznych";
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFile.Location = new System.Drawing.Point(6, 29);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(314, 22);
            this.txtFile.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.Location = new System.Drawing.Point(333, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Wyszukaj...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSkipFirst);
            this.groupBox1.Controls.Add(this.txtFile);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(25, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz plik";
            // 
            // chkSkipFirst
            // 
            this.chkSkipFirst.AutoSize = true;
            this.chkSkipFirst.Location = new System.Drawing.Point(7, 56);
            this.chkSkipFirst.Name = "chkSkipFirst";
            this.chkSkipFirst.Size = new System.Drawing.Size(179, 20);
            this.chkSkipFirst.TabIndex = 3;
            this.chkSkipFirst.Text = "pomiń pierwszy wiersz";
            this.chkSkipFirst.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cboZRD);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboSTB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cboBPP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboY);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboX);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboRZG);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboNr);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(25, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 186);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Struktura pliku";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.txtInnySeparator);
            this.groupBox4.Controls.Add(this.rbnInne);
            this.groupBox4.Controls.Add(this.rbnTab);
            this.groupBox4.Controls.Add(this.rbnSpacja);
            this.groupBox4.Controls.Add(this.rbnPrzecinek);
            this.groupBox4.Controls.Add(this.rbnSrednik);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(6, 90);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(422, 91);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Separator w pliku";
            // 
            // txtInnySeparator
            // 
            this.txtInnySeparator.Location = new System.Drawing.Point(238, 59);
            this.txtInnySeparator.Margin = new System.Windows.Forms.Padding(2);
            this.txtInnySeparator.Name = "txtInnySeparator";
            this.txtInnySeparator.Size = new System.Drawing.Size(150, 21);
            this.txtInnySeparator.TabIndex = 5;
            this.txtInnySeparator.Visible = false;
            // 
            // rbnInne
            // 
            this.rbnInne.AutoSize = true;
            this.rbnInne.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbnInne.Location = new System.Drawing.Point(238, 27);
            this.rbnInne.Margin = new System.Windows.Forms.Padding(2);
            this.rbnInne.Name = "rbnInne";
            this.rbnInne.Size = new System.Drawing.Size(49, 19);
            this.rbnInne.TabIndex = 4;
            this.rbnInne.Text = "Inne";
            this.rbnInne.UseVisualStyleBackColor = true;
            // 
            // rbnTab
            // 
            this.rbnTab.AutoSize = true;
            this.rbnTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbnTab.Location = new System.Drawing.Point(143, 59);
            this.rbnTab.Margin = new System.Windows.Forms.Padding(2);
            this.rbnTab.Name = "rbnTab";
            this.rbnTab.Size = new System.Drawing.Size(73, 19);
            this.rbnTab.TabIndex = 3;
            this.rbnTab.Text = "tabulator";
            this.rbnTab.UseVisualStyleBackColor = true;
            // 
            // rbnSpacja
            // 
            this.rbnSpacja.AutoSize = true;
            this.rbnSpacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbnSpacja.Location = new System.Drawing.Point(143, 27);
            this.rbnSpacja.Margin = new System.Windows.Forms.Padding(2);
            this.rbnSpacja.Name = "rbnSpacja";
            this.rbnSpacja.Size = new System.Drawing.Size(61, 19);
            this.rbnSpacja.TabIndex = 2;
            this.rbnSpacja.Text = "spacja";
            this.rbnSpacja.UseVisualStyleBackColor = true;
            // 
            // rbnPrzecinek
            // 
            this.rbnPrzecinek.AutoSize = true;
            this.rbnPrzecinek.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbnPrzecinek.Location = new System.Drawing.Point(20, 59);
            this.rbnPrzecinek.Margin = new System.Windows.Forms.Padding(2);
            this.rbnPrzecinek.Name = "rbnPrzecinek";
            this.rbnPrzecinek.Size = new System.Drawing.Size(78, 19);
            this.rbnPrzecinek.TabIndex = 1;
            this.rbnPrzecinek.Text = "przecinek";
            this.rbnPrzecinek.UseVisualStyleBackColor = true;
            // 
            // rbnSrednik
            // 
            this.rbnSrednik.AutoSize = true;
            this.rbnSrednik.Checked = true;
            this.rbnSrednik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbnSrednik.Location = new System.Drawing.Point(20, 27);
            this.rbnSrednik.Margin = new System.Windows.Forms.Padding(2);
            this.rbnSrednik.Name = "rbnSrednik";
            this.rbnSrednik.Size = new System.Drawing.Size(65, 19);
            this.rbnSrednik.TabIndex = 0;
            this.rbnSrednik.TabStop = true;
            this.rbnSrednik.Text = "średnik";
            this.rbnSrednik.UseVisualStyleBackColor = true;
            // 
            // cboZRD
            // 
            this.cboZRD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboZRD.FormattingEnabled = true;
            this.cboZRD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "brak"});
            this.cboZRD.Location = new System.Drawing.Point(353, 19);
            this.cboZRD.Name = "cboZRD";
            this.cboZRD.Size = new System.Drawing.Size(56, 24);
            this.cboZRD.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(317, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "ZRD";
            // 
            // cboSTB
            // 
            this.cboSTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboSTB.FormattingEnabled = true;
            this.cboSTB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "brak"});
            this.cboSTB.Location = new System.Drawing.Point(255, 47);
            this.cboSTB.Name = "cboSTB";
            this.cboSTB.Size = new System.Drawing.Size(56, 24);
            this.cboSTB.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(221, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "STB";
            // 
            // cboBPP
            // 
            this.cboBPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboBPP.FormattingEnabled = true;
            this.cboBPP.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "brak"});
            this.cboBPP.Location = new System.Drawing.Point(255, 19);
            this.cboBPP.Name = "cboBPP";
            this.cboBPP.Size = new System.Drawing.Size(56, 24);
            this.cboBPP.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(221, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "BPP";
            // 
            // cboY
            // 
            this.cboY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboY.FormattingEnabled = true;
            this.cboY.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboY.Location = new System.Drawing.Point(157, 46);
            this.cboY.Name = "cboY";
            this.cboY.Size = new System.Drawing.Size(56, 24);
            this.cboY.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(137, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Y";
            // 
            // cboX
            // 
            this.cboX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboX.FormattingEnabled = true;
            this.cboX.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboX.Location = new System.Drawing.Point(157, 19);
            this.cboX.Name = "cboX";
            this.cboX.Size = new System.Drawing.Size(56, 24);
            this.cboX.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(137, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "X";
            // 
            // cboRZG
            // 
            this.cboRZG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboRZG.FormattingEnabled = true;
            this.cboRZG.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "brak"});
            this.cboRZG.Location = new System.Drawing.Point(353, 48);
            this.cboRZG.Name = "cboRZG";
            this.cboRZG.Size = new System.Drawing.Size(56, 24);
            this.cboRZG.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(317, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "RZG";
            // 
            // cboNr
            // 
            this.cboNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboNr.FormattingEnabled = true;
            this.cboNr.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboNr.Location = new System.Drawing.Point(68, 19);
            this.cboNr.Name = "cboNr";
            this.cboNr.Size = new System.Drawing.Size(56, 24);
            this.cboNr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkInsertFileName);
            this.groupBox3.Controls.Add(this.cboWarstwy);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTextHeight);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(25, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 95);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parametry wczytywania";
            // 
            // chkInsertFileName
            // 
            this.chkInsertFileName.AutoSize = true;
            this.chkInsertFileName.Location = new System.Drawing.Point(184, 25);
            this.chkInsertFileName.Name = "chkInsertFileName";
            this.chkInsertFileName.Size = new System.Drawing.Size(236, 20);
            this.chkInsertFileName.TabIndex = 4;
            this.chkInsertFileName.Text = "Wstaw nazwe pliku do atrybutu";
            this.chkInsertFileName.UseVisualStyleBackColor = true;
            // 
            // cboWarstwy
            // 
            this.cboWarstwy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboWarstwy.FormattingEnabled = true;
            this.cboWarstwy.Location = new System.Drawing.Point(110, 54);
            this.cboWarstwy.Name = "cboWarstwy";
            this.cboWarstwy.Size = new System.Drawing.Size(210, 24);
            this.cboWarstwy.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(42, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Warstwa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Wysokość tekstu";
            // 
            // txtTextHeight
            // 
            this.txtTextHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTextHeight.Location = new System.Drawing.Point(130, 23);
            this.txtTextHeight.Name = "txtTextHeight";
            this.txtTextHeight.Size = new System.Drawing.Size(41, 22);
            this.txtTextHeight.TabIndex = 0;
            this.txtTextHeight.Text = "1";
            this.txtTextHeight.TextChanged += new System.EventHandler(this.txtTextHeight_TextChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(22, 496);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(65, 13);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Informacje...";
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(378, 456);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(91, 33);
            this.btnWczytaj.TabIndex = 7;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // WczytajPunktyGraniczneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 526);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "WczytajPunktyGraniczneForm";
            this.Text = "Wczytywanie Punktów Granicznych";
            this.Load += new System.EventHandler(this.WczytajPunktyGraniczneForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboZRD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboSTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboBPP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboRZG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTextHeight;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.ComboBox cboWarstwy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtInnySeparator;
        private System.Windows.Forms.RadioButton rbnInne;
        private System.Windows.Forms.RadioButton rbnTab;
        private System.Windows.Forms.RadioButton rbnSpacja;
        private System.Windows.Forms.RadioButton rbnPrzecinek;
        private System.Windows.Forms.RadioButton rbnSrednik;
        private System.Windows.Forms.CheckBox chkInsertFileName;
        private System.Windows.Forms.CheckBox chkSkipFirst;
    }
}