namespace abi_couche
{
    partial class FrmDetailContrat
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
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.lblSalaire = new System.Windows.Forms.Label();
            this.tbSalaire = new System.Windows.Forms.TextBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.tbMotif = new System.Windows.Forms.TextBox();
            this.gbContrat = new System.Windows.Forms.GroupBox();
            this.tbAgenceEcole = new System.Windows.Forms.TextBox();
            this.lblAgenceEcole = new System.Windows.Forms.Label();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbStage = new System.Windows.Forms.RadioButton();
            this.rbInterim = new System.Windows.Forms.RadioButton();
            this.rbCDD = new System.Windows.Forms.RadioButton();
            this.rbCDI = new System.Windows.Forms.RadioButton();
            this.dbFin = new System.Windows.Forms.DateTimePicker();
            this.dpDebut = new System.Windows.Forms.DateTimePicker();
            this.gbMotif = new System.Windows.Forms.GroupBox();
            this.gbContrat.SuspendLayout();
            this.gbType.SuspendLayout();
            this.gbMotif.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(193, 331);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 0;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(274, 331);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Valider";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // lblSalaire
            // 
            this.lblSalaire.AutoSize = true;
            this.lblSalaire.Location = new System.Drawing.Point(27, 21);
            this.lblSalaire.Name = "lblSalaire";
            this.lblSalaire.Size = new System.Drawing.Size(39, 13);
            this.lblSalaire.TabIndex = 2;
            this.lblSalaire.Text = "Salaire";
            // 
            // tbSalaire
            // 
            this.tbSalaire.Location = new System.Drawing.Point(133, 18);
            this.tbSalaire.Name = "tbSalaire";
            this.tbSalaire.Size = new System.Drawing.Size(184, 20);
            this.tbSalaire.TabIndex = 3;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(27, 50);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(75, 13);
            this.lblDateDebut.TabIndex = 4;
            this.lblDateDebut.Text = "Date de début";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(27, 76);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(62, 13);
            this.lblDateFin.TabIndex = 6;
            this.lblDateFin.Text = "Date de Fin";
            // 
            // tbMotif
            // 
            this.tbMotif.Location = new System.Drawing.Point(8, 19);
            this.tbMotif.Multiline = true;
            this.tbMotif.Name = "tbMotif";
            this.tbMotif.Size = new System.Drawing.Size(260, 75);
            this.tbMotif.TabIndex = 8;
            // 
            // gbContrat
            // 
            this.gbContrat.Controls.Add(this.tbAgenceEcole);
            this.gbContrat.Controls.Add(this.lblAgenceEcole);
            this.gbContrat.Controls.Add(this.gbType);
            this.gbContrat.Controls.Add(this.dbFin);
            this.gbContrat.Controls.Add(this.dpDebut);
            this.gbContrat.Controls.Add(this.lblSalaire);
            this.gbContrat.Controls.Add(this.tbSalaire);
            this.gbContrat.Controls.Add(this.lblDateDebut);
            this.gbContrat.Controls.Add(this.lblDateFin);
            this.gbContrat.Controls.Add(this.gbMotif);
            this.gbContrat.Location = new System.Drawing.Point(13, 13);
            this.gbContrat.Name = "gbContrat";
            this.gbContrat.Size = new System.Drawing.Size(336, 312);
            this.gbContrat.TabIndex = 10;
            this.gbContrat.TabStop = false;
            this.gbContrat.Text = "groupBox1";
            // 
            // tbAgenceEcole
            // 
            this.tbAgenceEcole.Location = new System.Drawing.Point(133, 96);
            this.tbAgenceEcole.Name = "tbAgenceEcole";
            this.tbAgenceEcole.Size = new System.Drawing.Size(184, 20);
            this.tbAgenceEcole.TabIndex = 9;
            // 
            // lblAgenceEcole
            // 
            this.lblAgenceEcole.AutoSize = true;
            this.lblAgenceEcole.Location = new System.Drawing.Point(27, 99);
            this.lblAgenceEcole.Name = "lblAgenceEcole";
            this.lblAgenceEcole.Size = new System.Drawing.Size(76, 13);
            this.lblAgenceEcole.TabIndex = 14;
            this.lblAgenceEcole.Text = "Agence/Ecole";
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbStage);
            this.gbType.Controls.Add(this.rbInterim);
            this.gbType.Controls.Add(this.rbCDD);
            this.gbType.Controls.Add(this.rbCDI);
            this.gbType.Location = new System.Drawing.Point(9, 228);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(274, 69);
            this.gbType.TabIndex = 13;
            this.gbType.TabStop = false;
            this.gbType.Text = "Type de Contrat";
            // 
            // rbStage
            // 
            this.rbStage.AutoSize = true;
            this.rbStage.Location = new System.Drawing.Point(215, 28);
            this.rbStage.Name = "rbStage";
            this.rbStage.Size = new System.Drawing.Size(53, 17);
            this.rbStage.TabIndex = 3;
            this.rbStage.TabStop = true;
            this.rbStage.Text = "Stage";
            this.rbStage.UseVisualStyleBackColor = true;
            // 
            // rbInterim
            // 
            this.rbInterim.AutoSize = true;
            this.rbInterim.Location = new System.Drawing.Point(142, 28);
            this.rbInterim.Name = "rbInterim";
            this.rbInterim.Size = new System.Drawing.Size(56, 17);
            this.rbInterim.TabIndex = 2;
            this.rbInterim.TabStop = true;
            this.rbInterim.Text = "Interim";
            this.rbInterim.UseVisualStyleBackColor = true;
            // 
            // rbCDD
            // 
            this.rbCDD.AutoSize = true;
            this.rbCDD.Location = new System.Drawing.Point(72, 28);
            this.rbCDD.Name = "rbCDD";
            this.rbCDD.Size = new System.Drawing.Size(48, 17);
            this.rbCDD.TabIndex = 1;
            this.rbCDD.TabStop = true;
            this.rbCDD.Text = "CDD";
            this.rbCDD.UseVisualStyleBackColor = true;
            // 
            // rbCDI
            // 
            this.rbCDI.AutoSize = true;
            this.rbCDI.Location = new System.Drawing.Point(8, 28);
            this.rbCDI.Name = "rbCDI";
            this.rbCDI.Size = new System.Drawing.Size(43, 17);
            this.rbCDI.TabIndex = 0;
            this.rbCDI.TabStop = true;
            this.rbCDI.Text = "CDI";
            this.rbCDI.UseVisualStyleBackColor = true;
            // 
            // dbFin
            // 
            this.dbFin.Location = new System.Drawing.Point(133, 70);
            this.dbFin.Name = "dbFin";
            this.dbFin.Size = new System.Drawing.Size(184, 20);
            this.dbFin.TabIndex = 11;
            // 
            // dpDebut
            // 
            this.dpDebut.Location = new System.Drawing.Point(133, 44);
            this.dpDebut.Name = "dpDebut";
            this.dpDebut.Size = new System.Drawing.Size(184, 20);
            this.dpDebut.TabIndex = 10;
            // 
            // gbMotif
            // 
            this.gbMotif.Controls.Add(this.tbMotif);
            this.gbMotif.Location = new System.Drawing.Point(9, 122);
            this.gbMotif.Name = "gbMotif";
            this.gbMotif.Size = new System.Drawing.Size(274, 100);
            this.gbMotif.TabIndex = 12;
            this.gbMotif.TabStop = false;
            this.gbMotif.Text = "Motif";
            // 
            // FrmDetailContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 363);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.gbContrat);
            this.Name = "FrmDetailContrat";
            this.Text = "FrmDetailContrat";
            this.gbContrat.ResumeLayout(false);
            this.gbContrat.PerformLayout();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbMotif.ResumeLayout(false);
            this.gbMotif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button buttonAnnuler;
        internal System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label lblSalaire;
        internal System.Windows.Forms.TextBox tbSalaire;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        internal System.Windows.Forms.TextBox tbMotif;
        internal System.Windows.Forms.GroupBox gbContrat;
        internal System.Windows.Forms.DateTimePicker dpDebut;
        internal System.Windows.Forms.DateTimePicker dbFin;
        internal System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.GroupBox gbMotif;
        internal System.Windows.Forms.RadioButton rbInterim;
        internal System.Windows.Forms.RadioButton rbCDD;
        internal System.Windows.Forms.RadioButton rbCDI;
        internal System.Windows.Forms.RadioButton rbStage;
        private System.Windows.Forms.Label lblAgenceEcole;
        internal System.Windows.Forms.TextBox tbAgenceEcole;
    }
}