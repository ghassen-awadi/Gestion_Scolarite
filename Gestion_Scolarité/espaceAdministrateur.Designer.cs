
namespace Gestion_Scolarité
{
    partial class espaceAdministrateur
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
            this.gestionEnseignantsRadioButton = new System.Windows.Forms.RadioButton();
            this.gestionEtudiantsRadioButton = new System.Windows.Forms.RadioButton();
            this.gestionEmploisRadioButton = new System.Windows.Forms.RadioButton();
            this.gestionGroupesRadioButton = new System.Windows.Forms.RadioButton();
            this.suivantButtonEspaceAdminisrateur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(92, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez choisir une option";
            // 
            // gestionEnseignantsRadioButton
            // 
            this.gestionEnseignantsRadioButton.AutoSize = true;
            this.gestionEnseignantsRadioButton.Location = new System.Drawing.Point(135, 124);
            this.gestionEnseignantsRadioButton.Name = "gestionEnseignantsRadioButton";
            this.gestionEnseignantsRadioButton.Size = new System.Drawing.Size(141, 17);
            this.gestionEnseignantsRadioButton.TabIndex = 1;
            this.gestionEnseignantsRadioButton.TabStop = true;
            this.gestionEnseignantsRadioButton.Text = "Gestion des enseignants";
            this.gestionEnseignantsRadioButton.UseVisualStyleBackColor = true;
            // 
            // gestionEtudiantsRadioButton
            // 
            this.gestionEtudiantsRadioButton.AutoSize = true;
            this.gestionEtudiantsRadioButton.Location = new System.Drawing.Point(135, 178);
            this.gestionEtudiantsRadioButton.Name = "gestionEtudiantsRadioButton";
            this.gestionEtudiantsRadioButton.Size = new System.Drawing.Size(127, 17);
            this.gestionEtudiantsRadioButton.TabIndex = 2;
            this.gestionEtudiantsRadioButton.TabStop = true;
            this.gestionEtudiantsRadioButton.Text = "Gestion des étudiants";
            this.gestionEtudiantsRadioButton.UseVisualStyleBackColor = true;
            // 
            // gestionEmploisRadioButton
            // 
            this.gestionEmploisRadioButton.AutoSize = true;
            this.gestionEmploisRadioButton.Location = new System.Drawing.Point(135, 234);
            this.gestionEmploisRadioButton.Name = "gestionEmploisRadioButton";
            this.gestionEmploisRadioButton.Size = new System.Drawing.Size(119, 17);
            this.gestionEmploisRadioButton.TabIndex = 3;
            this.gestionEmploisRadioButton.TabStop = true;
            this.gestionEmploisRadioButton.Text = "Gestion des emplois";
            this.gestionEmploisRadioButton.UseVisualStyleBackColor = true;
            // 
            // gestionGroupesRadioButton
            // 
            this.gestionGroupesRadioButton.AutoSize = true;
            this.gestionGroupesRadioButton.Location = new System.Drawing.Point(135, 297);
            this.gestionGroupesRadioButton.Name = "gestionGroupesRadioButton";
            this.gestionGroupesRadioButton.Size = new System.Drawing.Size(122, 17);
            this.gestionGroupesRadioButton.TabIndex = 4;
            this.gestionGroupesRadioButton.TabStop = true;
            this.gestionGroupesRadioButton.Text = "Gestion des groupes";
            this.gestionGroupesRadioButton.UseVisualStyleBackColor = true;
            // 
            // suivantButtonEspaceAdminisrateur
            // 
            this.suivantButtonEspaceAdminisrateur.Location = new System.Drawing.Point(526, 368);
            this.suivantButtonEspaceAdminisrateur.Name = "suivantButtonEspaceAdminisrateur";
            this.suivantButtonEspaceAdminisrateur.Size = new System.Drawing.Size(75, 23);
            this.suivantButtonEspaceAdminisrateur.TabIndex = 5;
            this.suivantButtonEspaceAdminisrateur.Text = "Suivant";
            this.suivantButtonEspaceAdminisrateur.UseVisualStyleBackColor = true;
            this.suivantButtonEspaceAdminisrateur.Click += new System.EventHandler(this.suivantButtonEspaceAdminisrateur_Click);
            // 
            // espaceAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(709, 429);
            this.Controls.Add(this.suivantButtonEspaceAdminisrateur);
            this.Controls.Add(this.gestionGroupesRadioButton);
            this.Controls.Add(this.gestionEmploisRadioButton);
            this.Controls.Add(this.gestionEtudiantsRadioButton);
            this.Controls.Add(this.gestionEnseignantsRadioButton);
            this.Controls.Add(this.label1);
            this.Name = "espaceAdministrateur";
            this.Text = "Espace Administrateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton gestionEnseignantsRadioButton;
        private System.Windows.Forms.RadioButton gestionEtudiantsRadioButton;
        private System.Windows.Forms.RadioButton gestionEmploisRadioButton;
        private System.Windows.Forms.RadioButton gestionGroupesRadioButton;
        private System.Windows.Forms.Button suivantButtonEspaceAdminisrateur;
    }
}

