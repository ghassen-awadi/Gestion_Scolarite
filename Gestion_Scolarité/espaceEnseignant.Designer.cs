
namespace Gestion_Scolarité
{
    partial class espaceEnseignant
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
            this.label2 = new System.Windows.Forms.Label();
            this.classeComboBox = new System.Windows.Forms.ComboBox();
            this.espaceEnseignantDataGridView = new System.Windows.Forms.DataGridView();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.espaceEnseignantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Classe:";
            // 
            // classeComboBox
            // 
            this.classeComboBox.FormattingEnabled = true;
            this.classeComboBox.Location = new System.Drawing.Point(266, 42);
            this.classeComboBox.Name = "classeComboBox";
            this.classeComboBox.Size = new System.Drawing.Size(226, 21);
            this.classeComboBox.TabIndex = 8;
            this.classeComboBox.SelectedIndexChanged += new System.EventHandler(this.classeComboBox_SelectedIndexChanged);
            // 
            // espaceEnseignantDataGridView
            // 
            this.espaceEnseignantDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.espaceEnseignantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.espaceEnseignantDataGridView.Location = new System.Drawing.Point(77, 94);
            this.espaceEnseignantDataGridView.Name = "espaceEnseignantDataGridView";
            this.espaceEnseignantDataGridView.Size = new System.Drawing.Size(597, 282);
            this.espaceEnseignantDataGridView.TabIndex = 9;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(333, 403);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(89, 23);
            this.logOutButton.TabIndex = 10;
            this.logOutButton.Text = "Déconnexion";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // espaceEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.espaceEnseignantDataGridView);
            this.Controls.Add(this.classeComboBox);
            this.Controls.Add(this.label2);
            this.Name = "espaceEnseignant";
            this.Text = "Espace Enseignant";
            ((System.ComponentModel.ISupportInitialize)(this.espaceEnseignantDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox classeComboBox;
        private System.Windows.Forms.DataGridView espaceEnseignantDataGridView;
        private System.Windows.Forms.Button logOutButton;
    }
}