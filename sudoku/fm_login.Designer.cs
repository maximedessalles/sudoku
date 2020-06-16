namespace sudoku
{
    partial class fm_login
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
            this.bt_connexion = new System.Windows.Forms.Button();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_10scores = new System.Windows.Forms.DataGridView();
            this.lb_erreur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_10scores)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_connexion
            // 
            this.bt_connexion.Location = new System.Drawing.Point(12, 94);
            this.bt_connexion.Name = "bt_connexion";
            this.bt_connexion.Size = new System.Drawing.Size(191, 23);
            this.bt_connexion.TabIndex = 0;
            this.bt_connexion.Text = "Se connecter";
            this.bt_connexion.UseVisualStyleBackColor = true;
            this.bt_connexion.Click += new System.EventHandler(this.bt_connexion_Click);
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(12, 54);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(191, 20);
            this.tb_login.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONNEXION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_10scores
            // 
            this.dgv_10scores.AllowUserToAddRows = false;
            this.dgv_10scores.AllowUserToDeleteRows = false;
            this.dgv_10scores.AllowUserToResizeColumns = false;
            this.dgv_10scores.AllowUserToResizeRows = false;
            this.dgv_10scores.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_10scores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_10scores.Location = new System.Drawing.Point(209, 9);
            this.dgv_10scores.Name = "dgv_10scores";
            this.dgv_10scores.Size = new System.Drawing.Size(211, 196);
            this.dgv_10scores.TabIndex = 5;
            // 
            // lb_erreur
            // 
            this.lb_erreur.AutoSize = true;
            this.lb_erreur.ForeColor = System.Drawing.Color.Red;
            this.lb_erreur.Location = new System.Drawing.Point(9, 192);
            this.lb_erreur.Name = "lb_erreur";
            this.lb_erreur.Size = new System.Drawing.Size(193, 13);
            this.lb_erreur.TabIndex = 6;
            this.lb_erreur.Text = "Vous ne pouvez pas choisir ce pseudo.";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 217);
            this.Controls.Add(this.lb_erreur);
            this.Controls.Add(this.dgv_10scores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.bt_connexion);
            this.Name = "login";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_10scores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_connexion;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_10scores;
        private System.Windows.Forms.Label lb_erreur;
    }
}

