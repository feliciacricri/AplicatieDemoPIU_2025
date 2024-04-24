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
            this.lblNote.Location = new System.Drawing.Point(57, 157);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 16);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Note";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(171, 42);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(194, 22);
            this.txtNume.TabIndex = 3;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(171, 96);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(194, 22);
            this.txtPrenume.TabIndex = 4;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(171, 151);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(194, 22);
            this.txtNote.TabIndex = 5;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(171, 203);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(88, 33);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(290, 203);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(75, 33);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMesajEroare);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

