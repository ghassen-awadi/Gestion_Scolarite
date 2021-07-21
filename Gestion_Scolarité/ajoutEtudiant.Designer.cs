
namespace Gestion_Scolarité
{
    partial class ajoutEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajoutEtudiant));
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numTelEtudiantTextBox = new System.Windows.Forms.TextBox();
            this.prenomEtudiantTextBox = new System.Windows.Forms.TextBox();
            this.nomEtudiantTextBox = new System.Windows.Forms.TextBox();
            this.groupeEtudiantTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(60, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Retour";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(63, 355);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 50);
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.RetourPictureBox_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AjouterEtudiantButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(163, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Groupe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(163, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Numéro Téléphone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(163, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Prénom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nom:";
            // 
            // numTelEtudiantTextBox
            // 
            this.numTelEtudiantTextBox.Location = new System.Drawing.Point(363, 175);
            this.numTelEtudiantTextBox.Name = "numTelEtudiantTextBox";
            this.numTelEtudiantTextBox.Size = new System.Drawing.Size(244, 20);
            this.numTelEtudiantTextBox.TabIndex = 25;
            this.numTelEtudiantTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTelEtudiantTextBox_KeyPress);
            // 
            // prenomEtudiantTextBox
            // 
            this.prenomEtudiantTextBox.Location = new System.Drawing.Point(363, 123);
            this.prenomEtudiantTextBox.Name = "prenomEtudiantTextBox";
            this.prenomEtudiantTextBox.Size = new System.Drawing.Size(244, 20);
            this.prenomEtudiantTextBox.TabIndex = 23;
            // 
            // nomEtudiantTextBox
            // 
            this.nomEtudiantTextBox.Location = new System.Drawing.Point(363, 70);
            this.nomEtudiantTextBox.Name = "nomEtudiantTextBox";
            this.nomEtudiantTextBox.Size = new System.Drawing.Size(244, 20);
            this.nomEtudiantTextBox.TabIndex = 22;
            // 
            // groupeEtudiantTextBox
            // 
            this.groupeEtudiantTextBox.Location = new System.Drawing.Point(363, 234);
            this.groupeEtudiantTextBox.Name = "groupeEtudiantTextBox";
            this.groupeEtudiantTextBox.Size = new System.Drawing.Size(244, 20);
            this.groupeEtudiantTextBox.TabIndex = 39;
            // 
            // ajoutEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupeEtudiantTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTelEtudiantTextBox);
            this.Controls.Add(this.prenomEtudiantTextBox);
            this.Controls.Add(this.nomEtudiantTextBox);
            this.Name = "ajoutEtudiant";
            this.Text = "Ajout Etudiant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numTelEtudiantTextBox;
        private System.Windows.Forms.TextBox prenomEtudiantTextBox;
        private System.Windows.Forms.TextBox nomEtudiantTextBox;
        private System.Windows.Forms.TextBox groupeEtudiantTextBox;
    }
}