namespace EvidentaStudenti_UI_WindowsForms
{
    partial class Form1
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.lblMesajEroare = new System.Windows.Forms.Label();
            this.gpbDiscipline = new System.Windows.Forms.GroupBox();
            this.ckbPCLP = new System.Windows.Forms.CheckBox();
            this.ckbPOO = new System.Windows.Forms.CheckBox();
            this.ckbPIU = new System.Windows.Forms.CheckBox();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.gpbProgrameStudiu = new System.Windows.Forms.GroupBox();
            this.rdbElectronica = new System.Windows.Forms.RadioButton();
            this.rdbCalculatoare = new System.Windows.Forms.RadioButton();
            this.rdbAutomatica = new System.Windows.Forms.RadioButton();
            this.lblSpecializare = new System.Windows.Forms.Label();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.dataGridStudenti = new System.Windows.Forms.DataGridView();
            this.gpbDiscipline.SuspendLayout();
            this.gpbProgrameStudiu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(57, 48);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(43, 16);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(57, 99);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(61, 16);
            this.lblPrenume.TabIndex = 1;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(57, 285);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 16);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Note";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(171, 48);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(273, 22);
            this.txtNume.TabIndex = 3;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(171, 96);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(273, 22);
            this.txtPrenume.TabIndex = 4;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(167, 285);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(277, 22);
            this.txtNote.TabIndex = 5;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(167, 337);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(146, 33);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(319, 337);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(125, 33);
            this.btnAfiseaza.TabIndex = 7;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // lblMesajEroare
            // 
            this.lblMesajEroare.AutoSize = true;
            this.lblMesajEroare.ForeColor = System.Drawing.Color.Red;
            this.lblMesajEroare.Location = new System.Drawing.Point(171, 266);
            this.lblMesajEroare.Name = "lblMesajEroare";
            this.lblMesajEroare.Size = new System.Drawing.Size(0, 16);
            this.lblMesajEroare.TabIndex = 8;
            // 
            // gpbDiscipline
            // 
            this.gpbDiscipline.Controls.Add(this.ckbPCLP);
            this.gpbDiscipline.Controls.Add(this.ckbPOO);
            this.gpbDiscipline.Controls.Add(this.ckbPIU);
            this.gpbDiscipline.Location = new System.Drawing.Point(167, 225);
            this.gpbDiscipline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbDiscipline.Name = "gpbDiscipline";
            this.gpbDiscipline.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbDiscipline.Size = new System.Drawing.Size(277, 50);
            this.gpbDiscipline.TabIndex = 41;
            this.gpbDiscipline.TabStop = false;
            // 
            // ckbPCLP
            // 
            this.ckbPCLP.AutoSize = true;
            this.ckbPCLP.Location = new System.Drawing.Point(16, 14);
            this.ckbPCLP.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPCLP.Name = "ckbPCLP";
            this.ckbPCLP.Size = new System.Drawing.Size(63, 20);
            this.ckbPCLP.TabIndex = 20;
            this.ckbPCLP.Text = "PCLP";
            this.ckbPCLP.UseVisualStyleBackColor = true;
            this.ckbPCLP.CheckedChanged += new System.EventHandler(this.CkbDiscipline_CheckedChanged);
            // 
            // ckbPOO
            // 
            this.ckbPOO.AutoSize = true;
            this.ckbPOO.Location = new System.Drawing.Point(120, 15);
            this.ckbPOO.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPOO.Name = "ckbPOO";
            this.ckbPOO.Size = new System.Drawing.Size(58, 20);
            this.ckbPOO.TabIndex = 21;
            this.ckbPOO.Text = "POO";
            this.ckbPOO.UseVisualStyleBackColor = true;
            this.ckbPOO.CheckedChanged += new System.EventHandler(this.CkbDiscipline_CheckedChanged);
            // 
            // ckbPIU
            // 
            this.ckbPIU.AutoSize = true;
            this.ckbPIU.Location = new System.Drawing.Point(219, 14);
            this.ckbPIU.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPIU.Name = "ckbPIU";
            this.ckbPIU.Size = new System.Drawing.Size(51, 20);
            this.ckbPIU.TabIndex = 22;
            this.ckbPIU.Text = "PIU";
            this.ckbPIU.UseVisualStyleBackColor = true;
            this.ckbPIU.CheckedChanged += new System.EventHandler(this.CkbDiscipline_CheckedChanged);
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(57, 225);
            this.lblDiscipline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(66, 16);
            this.lblDiscipline.TabIndex = 40;
            this.lblDiscipline.Text = "Discipline";
            // 
            // gpbProgrameStudiu
            // 
            this.gpbProgrameStudiu.Controls.Add(this.rdbElectronica);
            this.gpbProgrameStudiu.Controls.Add(this.rdbCalculatoare);
            this.gpbProgrameStudiu.Controls.Add(this.rdbAutomatica);
            this.gpbProgrameStudiu.Location = new System.Drawing.Point(167, 127);
            this.gpbProgrameStudiu.Margin = new System.Windows.Forms.Padding(4);
            this.gpbProgrameStudiu.Name = "gpbProgrameStudiu";
            this.gpbProgrameStudiu.Padding = new System.Windows.Forms.Padding(4);
            this.gpbProgrameStudiu.Size = new System.Drawing.Size(277, 77);
            this.gpbProgrameStudiu.TabIndex = 39;
            this.gpbProgrameStudiu.TabStop = false;
            // 
            // rdbElectronica
            // 
            this.rdbElectronica.AutoSize = true;
            this.rdbElectronica.Location = new System.Drawing.Point(20, 39);
            this.rdbElectronica.Margin = new System.Windows.Forms.Padding(4);
            this.rdbElectronica.Name = "rdbElectronica";
            this.rdbElectronica.Size = new System.Drawing.Size(95, 20);
            this.rdbElectronica.TabIndex = 10;
            this.rdbElectronica.TabStop = true;
            this.rdbElectronica.Text = "Electronica";
            this.rdbElectronica.UseVisualStyleBackColor = true;
            // 
            // rdbCalculatoare
            // 
            this.rdbCalculatoare.AutoSize = true;
            this.rdbCalculatoare.Location = new System.Drawing.Point(20, 11);
            this.rdbCalculatoare.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCalculatoare.Name = "rdbCalculatoare";
            this.rdbCalculatoare.Size = new System.Drawing.Size(104, 20);
            this.rdbCalculatoare.TabIndex = 8;
            this.rdbCalculatoare.TabStop = true;
            this.rdbCalculatoare.Text = "Calculatoare";
            this.rdbCalculatoare.UseVisualStyleBackColor = true;
            // 
            // rdbAutomatica
            // 
            this.rdbAutomatica.AutoSize = true;
            this.rdbAutomatica.Location = new System.Drawing.Point(140, 11);
            this.rdbAutomatica.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAutomatica.Name = "rdbAutomatica";
            this.rdbAutomatica.Size = new System.Drawing.Size(95, 20);
            this.rdbAutomatica.TabIndex = 9;
            this.rdbAutomatica.TabStop = true;
            this.rdbAutomatica.Text = "Automatica";
            this.rdbAutomatica.UseVisualStyleBackColor = true;
            // 
            // lblSpecializare
            // 
            this.lblSpecializare.AutoSize = true;
            this.lblSpecializare.Location = new System.Drawing.Point(57, 153);
            this.lblSpecializare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecializare.Name = "lblSpecializare";
            this.lblSpecializare.Size = new System.Drawing.Size(90, 16);
            this.lblSpecializare.TabIndex = 38;
            this.lblSpecializare.Text = "Specializarea";
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 16;
            this.lstAfisare.Location = new System.Drawing.Point(582, 240);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(527, 100);
            this.lstAfisare.TabIndex = 42;
            // 
            // dataGridStudenti
            // 
            this.dataGridStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudenti.Location = new System.Drawing.Point(582, 359);
            this.dataGridStudenti.Name = "dataGridStudenti";
            this.dataGridStudenti.RowHeadersWidth = 51;
            this.dataGridStudenti.RowTemplate.Height = 24;
            this.dataGridStudenti.Size = new System.Drawing.Size(527, 150);
            this.dataGridStudenti.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 555);
            this.Controls.Add(this.lblMesajEroare);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.gpbDiscipline);
            this.Controls.Add(this.lblDiscipline);
            this.Controls.Add(this.gpbProgrameStudiu);
            this.Controls.Add(this.lblSpecializare);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.dataGridStudenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbDiscipline.ResumeLayout(false);
            this.gpbDiscipline.PerformLayout();
            this.gpbProgrameStudiu.ResumeLayout(false);
            this.gpbProgrameStudiu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Label lblMesajEroare;
        private System.Windows.Forms.GroupBox gpbDiscipline;
        private System.Windows.Forms.CheckBox ckbPCLP;
        private System.Windows.Forms.CheckBox ckbPOO;
        private System.Windows.Forms.CheckBox ckbPIU;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.GroupBox gpbProgrameStudiu;
        private System.Windows.Forms.RadioButton rdbElectronica;
        private System.Windows.Forms.RadioButton rdbCalculatoare;
        private System.Windows.Forms.RadioButton rdbAutomatica;
        private System.Windows.Forms.Label lblSpecializare;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.DataGridView dataGridStudenti;
    }
}

