﻿namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_ajout = new System.Windows.Forms.Button();
            this.B_modif = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.B_supr = new System.Windows.Forms.Button();
            this.GB_Details = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ville = new System.Windows.Forms.TextBox();
            this.TB_prenom = new System.Windows.Forms.TextBox();
            this.TB_nom = new System.Windows.Forms.TextBox();
            this.GB_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_ajout
            // 
            this.B_ajout.Location = new System.Drawing.Point(315, 21);
            this.B_ajout.Name = "B_ajout";
            this.B_ajout.Size = new System.Drawing.Size(99, 24);
            this.B_ajout.TabIndex = 0;
            this.B_ajout.Text = "Ajouter";
            this.B_ajout.UseVisualStyleBackColor = true;
            this.B_ajout.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_modif
            // 
            this.B_modif.Location = new System.Drawing.Point(315, 64);
            this.B_modif.Name = "B_modif";
            this.B_modif.Size = new System.Drawing.Size(99, 23);
            this.B_modif.TabIndex = 1;
            this.B_modif.Text = "Modifier";
            this.B_modif.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(29, 21);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(235, 199);
            this.listBox.TabIndex = 2;
            // 
            // B_supr
            // 
            this.B_supr.Location = new System.Drawing.Point(315, 106);
            this.B_supr.Name = "B_supr";
            this.B_supr.Size = new System.Drawing.Size(99, 23);
            this.B_supr.TabIndex = 3;
            this.B_supr.Text = "Supprimer";
            this.B_supr.UseVisualStyleBackColor = true;
            // 
            // GB_Details
            // 
            this.GB_Details.Controls.Add(this.label3);
            this.GB_Details.Controls.Add(this.label2);
            this.GB_Details.Controls.Add(this.label1);
            this.GB_Details.Controls.Add(this.TB_ville);
            this.GB_Details.Controls.Add(this.TB_prenom);
            this.GB_Details.Controls.Add(this.TB_nom);
            this.GB_Details.Location = new System.Drawing.Point(465, 21);
            this.GB_Details.Name = "GB_Details";
            this.GB_Details.Size = new System.Drawing.Size(268, 199);
            this.GB_Details.TabIndex = 4;
            this.GB_Details.TabStop = false;
            this.GB_Details.Text = "Détails";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom";
            // 
            // TB_ville
            // 
            this.TB_ville.Location = new System.Drawing.Point(88, 139);
            this.TB_ville.Name = "TB_ville";
            this.TB_ville.Size = new System.Drawing.Size(149, 20);
            this.TB_ville.TabIndex = 7;
            // 
            // TB_prenom
            // 
            this.TB_prenom.Location = new System.Drawing.Point(88, 91);
            this.TB_prenom.Name = "TB_prenom";
            this.TB_prenom.Size = new System.Drawing.Size(149, 20);
            this.TB_prenom.TabIndex = 6;
            // 
            // TB_nom
            // 
            this.TB_nom.Location = new System.Drawing.Point(88, 43);
            this.TB_nom.Name = "TB_nom";
            this.TB_nom.Size = new System.Drawing.Size(149, 20);
            this.TB_nom.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 257);
            this.Controls.Add(this.GB_Details);
            this.Controls.Add(this.B_supr);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.B_modif);
            this.Controls.Add(this.B_ajout);
            this.Name = "Form1";
            this.Text = "Gestion des Clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_Details.ResumeLayout(false);
            this.GB_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_ajout;
        private System.Windows.Forms.Button B_modif;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button B_supr;
        private System.Windows.Forms.GroupBox GB_Details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_ville;
        private System.Windows.Forms.TextBox TB_prenom;
        private System.Windows.Forms.TextBox TB_nom;
    }
}

