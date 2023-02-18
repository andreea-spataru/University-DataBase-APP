namespace LoginForm
{
    partial class DatabaseMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMedie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtBirthData = new System.Windows.Forms.DateTimePicker();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.txtPho = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtJ = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.Label();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtCNP1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLastNam = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvLicence = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicence)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(815, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMedie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.dtBirthData);
            this.groupBox1.Controls.Add(this.txtSector);
            this.groupBox1.Controls.Add(this.txtPho);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtJ);
            this.groupBox1.Controls.Add(this.txtPhoneNo);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.dtBirth);
            this.groupBox1.Controls.Add(this.txtS);
            this.groupBox1.Controls.Add(this.txtCNP);
            this.groupBox1.Controls.Add(this.txtCNP1);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtLastNam);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Location = new System.Drawing.Point(57, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 385);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtMedie
            // 
            this.txtMedie.Location = new System.Drawing.Point(159, 332);
            this.txtMedie.Name = "txtMedie";
            this.txtMedie.Size = new System.Drawing.Size(179, 22);
            this.txtMedie.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Medie";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGender.Location = new System.Drawing.Point(159, 166);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(179, 24);
            this.cmbGender.TabIndex = 22;
            // 
            // dtBirthData
            // 
            this.dtBirthData.Location = new System.Drawing.Point(159, 200);
            this.dtBirthData.Name = "dtBirthData";
            this.dtBirthData.Size = new System.Drawing.Size(179, 22);
            this.dtBirthData.TabIndex = 17;
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(159, 269);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(179, 22);
            this.txtSector.TabIndex = 15;
            // 
            // txtPho
            // 
            this.txtPho.AutoSize = true;
            this.txtPho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPho.Location = new System.Drawing.Point(42, 300);
            this.txtPho.Name = "txtPho";
            this.txtPho.Size = new System.Drawing.Size(96, 16);
            this.txtPho.TabIndex = 14;
            this.txtPho.Text = "Numar Telefon";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(159, 235);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(179, 22);
            this.txtCity.TabIndex = 13;
            // 
            // txtJ
            // 
            this.txtJ.AutoSize = true;
            this.txtJ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtJ.Location = new System.Drawing.Point(42, 269);
            this.txtJ.Name = "txtJ";
            this.txtJ.Size = new System.Drawing.Size(40, 16);
            this.txtJ.TabIndex = 12;
            this.txtJ.Text = "Judet";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(159, 300);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(179, 22);
            this.txtPhoneNo.TabIndex = 11;
            // 
            // txtC
            // 
            this.txtC.AutoSize = true;
            this.txtC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtC.Location = new System.Drawing.Point(42, 238);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(36, 16);
            this.txtC.TabIndex = 10;
            this.txtC.Text = "Oras";
            // 
            // dtBirth
            // 
            this.dtBirth.AutoSize = true;
            this.dtBirth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtBirth.Location = new System.Drawing.Point(42, 205);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(85, 16);
            this.dtBirth.TabIndex = 8;
            this.dtBirth.Text = "Data Nasterii";
            // 
            // txtS
            // 
            this.txtS.AutoSize = true;
            this.txtS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtS.Location = new System.Drawing.Point(42, 174);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(30, 16);
            this.txtS.TabIndex = 6;
            this.txtS.Text = "Sex";
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(159, 124);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(179, 22);
            this.txtCNP.TabIndex = 5;
            // 
            // txtCNP1
            // 
            this.txtCNP1.AutoSize = true;
            this.txtCNP1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCNP1.Location = new System.Drawing.Point(41, 130);
            this.txtCNP1.Name = "txtCNP1";
            this.txtCNP1.Size = new System.Drawing.Size(35, 16);
            this.txtCNP1.TabIndex = 4;
            this.txtCNP1.Text = "CNP";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(159, 80);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(179, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // txtLastNam
            // 
            this.txtLastNam.AutoSize = true;
            this.txtLastNam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLastNam.Location = new System.Drawing.Point(41, 80);
            this.txtLastNam.Name = "txtLastNam";
            this.txtLastNam.Size = new System.Drawing.Size(61, 16);
            this.txtLastNam.TabIndex = 2;
            this.txtLastNam.Text = "Prenume";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtNam
            // 
            this.txtNam.AutoSize = true;
            this.txtNam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNam.Location = new System.Drawing.Point(41, 36);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(43, 16);
            this.txtNam.TabIndex = 0;
            this.txtNam.Text = "Nume";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Thistle;
            this.btnInsert.Location = new System.Drawing.Point(163, 606);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(105, 36);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Thistle;
            this.btnDelete.Location = new System.Drawing.Point(254, 554);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 36);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Thistle;
            this.btnUpdate.Location = new System.Drawing.Point(83, 553);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 37);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Thistle;
            this.btnSearch.Location = new System.Drawing.Point(520, 199);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 37);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvLicence
            // 
            this.dgvLicence.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvLicence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicence.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvLicence.Location = new System.Drawing.Point(641, 168);
            this.dgvLicence.Name = "dgvLicence";
            this.dgvLicence.RowHeadersWidth = 51;
            this.dgvLicence.RowTemplate.Height = 24;
            this.dgvLicence.Size = new System.Drawing.Size(563, 340);
            this.dgvLicence.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(987, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 35);
            this.button2.TabIndex = 25;
            this.button2.Text = "Teme Licenta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DatabaseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1249, 689);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvLicence);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInsert);
            this.Name = "DatabaseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseMenu";
            this.Load += new System.EventHandler(this.DatabaseMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtBirthData;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Label txtPho;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label txtJ;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label txtC;
        private System.Windows.Forms.Label dtBirth;
        private System.Windows.Forms.Label txtS;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label txtCNP1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label txtLastNam;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label txtNam;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvLicence;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMedie;
        private System.Windows.Forms.Label label1;
    }
}