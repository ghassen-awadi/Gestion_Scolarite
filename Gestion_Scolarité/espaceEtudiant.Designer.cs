
namespace Gestion_Scolarité
{
    partial class espaceEtudiant
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
            this.classeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.espaceEtudiantDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.jourTextBox = new System.Windows.Forms.TextBox();
            this.moisTextBox = new System.Windows.Forms.TextBox();
            this.anneeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.espaceEtudiantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // classeTextBox
            // 
            this.classeTextBox.Location = new System.Drawing.Point(352, 21);
            this.classeTextBox.Name = "classeTextBox";
            this.classeTextBox.Size = new System.Drawing.Size(234, 20);
            this.classeTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Classe:";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(302, 403);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(89, 23);
            this.logOutButton.TabIndex = 12;
            this.logOutButton.Text = "Déconnexion";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // espaceEtudiantDataGridView
            // 
            this.espaceEtudiantDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.espaceEtudiantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.espaceEtudiantDataGridView.Location = new System.Drawing.Point(119, 98);
            this.espaceEtudiantDataGridView.Name = "espaceEtudiantDataGridView";
            this.espaceEtudiantDataGridView.ReadOnly = true;
            this.espaceEtudiantDataGridView.Size = new System.Drawing.Size(597, 282);
            this.espaceEtudiantDataGridView.TabIndex = 11;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(416, 403);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 23);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Rechercher";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date:";
            // 
            // jourTextBox
            // 
            this.jourTextBox.ForeColor = System.Drawing.Color.Silver;
            this.jourTextBox.Location = new System.Drawing.Point(352, 62);
            this.jourTextBox.Name = "jourTextBox";
            this.jourTextBox.Size = new System.Drawing.Size(66, 20);
            this.jourTextBox.TabIndex = 15;
            this.jourTextBox.Text = "JOUR";
            this.jourTextBox.Enter += new System.EventHandler(this.jourTextBox_Enter);
            this.jourTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jourTextBox_KeyPress);
            this.jourTextBox.Leave += new System.EventHandler(this.jourTextBox_Leave);
            // 
            // moisTextBox
            // 
            this.moisTextBox.ForeColor = System.Drawing.Color.Silver;
            this.moisTextBox.Location = new System.Drawing.Point(439, 62);
            this.moisTextBox.Name = "moisTextBox";
            this.moisTextBox.Size = new System.Drawing.Size(54, 20);
            this.moisTextBox.TabIndex = 16;
            this.moisTextBox.Text = "MOIS";
            this.moisTextBox.Enter += new System.EventHandler(this.moisTextBox_Enter);
            this.moisTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moisTextBox_KeyPress);
            this.moisTextBox.Leave += new System.EventHandler(this.moisTextBox_Leave);
            // 
            // anneeTextBox
            // 
            this.anneeTextBox.ForeColor = System.Drawing.Color.Silver;
            this.anneeTextBox.Location = new System.Drawing.Point(520, 62);
            this.anneeTextBox.Name = "anneeTextBox";
            this.anneeTextBox.Size = new System.Drawing.Size(57, 20);
            this.anneeTextBox.TabIndex = 17;
            this.anneeTextBox.Text = "ANNEE";
            this.anneeTextBox.Enter += new System.EventHandler(this.anneeTextBox_Enter);
            this.anneeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anneeTextBox_KeyPress);
            this.anneeTextBox.Leave += new System.EventHandler(this.anneeTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(424, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(499, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "-";
            // 
            // espaceEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.anneeTextBox);
            this.Controls.Add(this.moisTextBox);
            this.Controls.Add(this.jourTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.espaceEtudiantDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classeTextBox);
            this.Name = "espaceEtudiant";
            this.Text = "Espace Etudiant";
            ((System.ComponentModel.ISupportInitialize)(this.espaceEtudiantDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox classeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.DataGridView espaceEtudiantDataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jourTextBox;
        private System.Windows.Forms.TextBox moisTextBox;
        private System.Windows.Forms.TextBox anneeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}