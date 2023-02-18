namespace LoginForm
{
    partial class TemeLicenta
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
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.dgvLicence1 = new System.Windows.Forms.DataGridView();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLastIn = new System.Windows.Forms.TextBox();
            this.txtNameIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.dtLimit = new System.Windows.Forms.DateTimePicker();
            this.txtLang = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.Label();
            this.txtCNP1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtLastNam = new System.Windows.Forms.Label();
            this.txtNameHom = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.Label();
            this.btnInsert1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicence1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.Thistle;
            this.btnDelete1.Location = new System.Drawing.Point(308, 491);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(105, 36);
            this.btnDelete1.TabIndex = 28;
            this.btnDelete1.Text = "Delete";
            this.btnDelete1.UseVisualStyleBackColor = false;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // dgvLicence1
            // 
            this.dgvLicence1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvLicence1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicence1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvLicence1.Location = new System.Drawing.Point(695, 105);
            this.dgvLicence1.Name = "dgvLicence1";
            this.dgvLicence1.RowHeadersWidth = 51;
            this.dgvLicence1.RowTemplate.Height = 24;
            this.dgvLicence1.Size = new System.Drawing.Size(563, 340);
            this.dgvLicence1.TabIndex = 31;
            this.dgvLicence1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLicence1_CellEnter);
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.Color.Thistle;
            this.btnSearch1.Location = new System.Drawing.Point(574, 136);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(105, 37);
            this.btnSearch1.TabIndex = 30;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = false;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(869, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 32;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.BackColor = System.Drawing.Color.Thistle;
            this.btnUpdate1.Location = new System.Drawing.Point(137, 490);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(105, 37);
            this.btnUpdate1.TabIndex = 29;
            this.btnUpdate1.Text = "Update";
            this.btnUpdate1.UseVisualStyleBackColor = false;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLastIn);
            this.groupBox1.Controls.Add(this.txtNameIn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHours);
            this.groupBox1.Controls.Add(this.dtLimit);
            this.groupBox1.Controls.Add(this.txtLang);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.txtS);
            this.groupBox1.Controls.Add(this.txtCNP1);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.txtLastNam);
            this.groupBox1.Controls.Add(this.txtNameHom);
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Location = new System.Drawing.Point(92, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 329);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtLastIn
            // 
            this.txtLastIn.Location = new System.Drawing.Point(159, 274);
            this.txtLastIn.Name = "txtLastIn";
            this.txtLastIn.Size = new System.Drawing.Size(179, 22);
            this.txtLastIn.TabIndex = 22;
            // 
            // txtNameIn
            // 
            this.txtNameIn.Location = new System.Drawing.Point(159, 243);
            this.txtNameIn.Name = "txtNameIn";
            this.txtNameIn.Size = new System.Drawing.Size(179, 22);
            this.txtNameIn.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prenume Indrumator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nume Indrumator";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(159, 166);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(179, 22);
            this.txtHours.TabIndex = 18;
            // 
            // dtLimit
            // 
            this.dtLimit.Location = new System.Drawing.Point(159, 130);
            this.dtLimit.Name = "dtLimit";
            this.dtLimit.Size = new System.Drawing.Size(179, 22);
            this.dtLimit.TabIndex = 17;
            // 
            // txtLang
            // 
            this.txtLang.Location = new System.Drawing.Point(159, 208);
            this.txtLang.Name = "txtLang";
            this.txtLang.Size = new System.Drawing.Size(179, 22);
            this.txtLang.TabIndex = 13;
            // 
            // txtC
            // 
            this.txtC.AutoSize = true;
            this.txtC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtC.Location = new System.Drawing.Point(42, 208);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(44, 16);
            this.txtC.TabIndex = 10;
            this.txtC.Text = "Limba";
            // 
            // txtS
            // 
            this.txtS.AutoSize = true;
            this.txtS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtS.Location = new System.Drawing.Point(41, 166);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(70, 32);
            this.txtS.TabIndex = 6;
            this.txtS.Text = "Numar ore\r\n de Lucru";
            // 
            // txtCNP1
            // 
            this.txtCNP1.AutoSize = true;
            this.txtCNP1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCNP1.Location = new System.Drawing.Point(41, 130);
            this.txtCNP1.Name = "txtCNP1";
            this.txtCNP1.Size = new System.Drawing.Size(92, 16);
            this.txtCNP1.TabIndex = 4;
            this.txtCNP1.Text = "Termen Limita";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(159, 80);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(179, 22);
            this.txtCode.TabIndex = 3;
            // 
            // txtLastNam
            // 
            this.txtLastNam.AutoSize = true;
            this.txtLastNam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLastNam.Location = new System.Drawing.Point(41, 80);
            this.txtLastNam.Name = "txtLastNam";
            this.txtLastNam.Size = new System.Drawing.Size(71, 16);
            this.txtLastNam.TabIndex = 2;
            this.txtLastNam.Text = "Cod Tema";
            // 
            // txtNameHom
            // 
            this.txtNameHom.Location = new System.Drawing.Point(159, 36);
            this.txtNameHom.Name = "txtNameHom";
            this.txtNameHom.Size = new System.Drawing.Size(179, 22);
            this.txtNameHom.TabIndex = 1;
            // 
            // txtNam
            // 
            this.txtNam.AutoSize = true;
            this.txtNam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNam.Location = new System.Drawing.Point(41, 36);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(82, 16);
            this.txtNam.TabIndex = 0;
            this.txtNam.Text = "Nume Teme";
            // 
            // btnInsert1
            // 
            this.btnInsert1.BackColor = System.Drawing.Color.Thistle;
            this.btnInsert1.Location = new System.Drawing.Point(217, 543);
            this.btnInsert1.Name = "btnInsert1";
            this.btnInsert1.Size = new System.Drawing.Size(105, 36);
            this.btnInsert1.TabIndex = 27;
            this.btnInsert1.Text = "Insert";
            this.btnInsert1.UseVisualStyleBackColor = false;
            this.btnInsert1.Click += new System.EventHandler(this.btnInsert1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(1065, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 35);
            this.button2.TabIndex = 33;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TemeLicenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1351, 679);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.dgvLicence1);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInsert1);
            this.Name = "TemeLicenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TemeLicenta";
            this.Load += new System.EventHandler(this.TemeLicenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicence1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.DataGridView dgvLicence1;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtLimit;
        private System.Windows.Forms.TextBox txtLang;
        private System.Windows.Forms.Label txtC;
        private System.Windows.Forms.Label txtS;
        private System.Windows.Forms.Label txtCNP1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label txtLastNam;
        private System.Windows.Forms.TextBox txtNameHom;
        private System.Windows.Forms.Label txtNam;
        private System.Windows.Forms.Button btnInsert1;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtLastIn;
        private System.Windows.Forms.TextBox txtNameIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}