namespace sudoku_cs
{
    partial class fm_sudoku
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
            this.btnSolution = new System.Windows.Forms.Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_pause = new System.Windows.Forms.Button();
            this.dgv_mesScores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_triche = new System.Windows.Forms.Label();
            this.bt_commencer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_tpTotal = new System.Windows.Forms.Label();
            this.lb_totalTemps = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_penalite = new System.Windows.Forms.Label();
            this.lb_timer = new System.Windows.Forms.Label();
            this.lb_pseudo = new System.Windows.Forms.Label();
            this.bt_historique = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mesScores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSolution
            // 
            this.btnSolution.Location = new System.Drawing.Point(84, 305);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(75, 23);
            this.btnSolution.TabIndex = 9;
            this.btnSolution.Text = "Vérification";
            this.btnSolution.UseVisualStyleBackColor = true;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Facile",
            "Moyen",
            "Difficile"});
            this.ComboBox1.Location = new System.Drawing.Point(66, 59);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(174, 21);
            this.ComboBox1.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 62);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Difficulté";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(165, 305);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.ColumnHeadersVisible = false;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DataGridView1.Location = new System.Drawing.Point(12, 98);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(228, 201);
            this.DataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 25;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 25;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 25;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 25;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Width = 25;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Width = 25;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.Width = 25;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.Width = 25;
            // 
            // bt_pause
            // 
            this.bt_pause.Location = new System.Drawing.Point(12, 305);
            this.bt_pause.Name = "bt_pause";
            this.bt_pause.Size = new System.Drawing.Size(66, 23);
            this.bt_pause.TabIndex = 11;
            this.bt_pause.Text = "Pause";
            this.bt_pause.UseVisualStyleBackColor = true;
            this.bt_pause.Click += new System.EventHandler(this.bt_pause_Click);
            // 
            // dgv_mesScores
            // 
            this.dgv_mesScores.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_mesScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mesScores.Location = new System.Drawing.Point(284, 56);
            this.dgv_mesScores.Name = "dgv_mesScores";
            this.dgv_mesScores.Size = new System.Drawing.Size(216, 272);
            this.dgv_mesScores.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "VOS TEMPS";
            // 
            // lb_triche
            // 
            this.lb_triche.AutoSize = true;
            this.lb_triche.Location = new System.Drawing.Point(50, 195);
            this.lb_triche.Name = "lb_triche";
            this.lb_triche.Size = new System.Drawing.Size(161, 13);
            this.lb_triche.TabIndex = 15;
            this.lb_triche.Text = "Hop Hop Hop ! Pas de tricherie !";
            // 
            // bt_commencer
            // 
            this.bt_commencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_commencer.Location = new System.Drawing.Point(12, 83);
            this.bt_commencer.Name = "bt_commencer";
            this.bt_commencer.Size = new System.Drawing.Size(228, 37);
            this.bt_commencer.TabIndex = 16;
            this.bt_commencer.Text = "COMMENCER START COMENZAR COMINCIARE начало COMECO";
            this.bt_commencer.UseVisualStyleBackColor = true;
            this.bt_commencer.Click += new System.EventHandler(this.bt_commencer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_tpTotal);
            this.panel1.Controls.Add(this.lb_totalTemps);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lb_penalite);
            this.panel1.Controls.Add(this.lb_timer);
            this.panel1.Controls.Add(this.lb_pseudo);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 51);
            this.panel1.TabIndex = 21;
            // 
            // lb_tpTotal
            // 
            this.lb_tpTotal.AutoSize = true;
            this.lb_tpTotal.Location = new System.Drawing.Point(117, 32);
            this.lb_tpTotal.Name = "lb_tpTotal";
            this.lb_tpTotal.Size = new System.Drawing.Size(71, 13);
            this.lb_tpTotal.TabIndex = 21;
            this.lb_tpTotal.Text = "Temps total : ";
            // 
            // lb_totalTemps
            // 
            this.lb_totalTemps.AutoSize = true;
            this.lb_totalTemps.Location = new System.Drawing.Point(194, 32);
            this.lb_totalTemps.Name = "lb_totalTemps";
            this.lb_totalTemps.Size = new System.Drawing.Size(23, 13);
            this.lb_totalTemps.TabIndex = 20;
            this.lb_totalTemps.Text = "m:s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pénalité : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Temps : ";
            // 
            // lb_penalite
            // 
            this.lb_penalite.AutoSize = true;
            this.lb_penalite.Location = new System.Drawing.Point(193, 20);
            this.lb_penalite.Name = "lb_penalite";
            this.lb_penalite.Size = new System.Drawing.Size(24, 13);
            this.lb_penalite.TabIndex = 17;
            this.lb_penalite.Text = "00s";
            // 
            // lb_timer
            // 
            this.lb_timer.AutoSize = true;
            this.lb_timer.Location = new System.Drawing.Point(189, 7);
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(28, 13);
            this.lb_timer.TabIndex = 10;
            this.lb_timer.Text = "m:ss";
            // 
            // lb_pseudo
            // 
            this.lb_pseudo.AutoSize = true;
            this.lb_pseudo.Location = new System.Drawing.Point(3, 7);
            this.lb_pseudo.Name = "lb_pseudo";
            this.lb_pseudo.Size = new System.Drawing.Size(73, 13);
            this.lb_pseudo.TabIndex = 12;
            this.lb_pseudo.Text = "Pseudo : Test";
            // 
            // bt_historique
            // 
            this.bt_historique.Location = new System.Drawing.Point(284, 3);
            this.bt_historique.Name = "bt_historique";
            this.bt_historique.Size = new System.Drawing.Size(216, 23);
            this.bt_historique.TabIndex = 22;
            this.bt_historique.Text = "Historique des parties";
            this.bt_historique.UseVisualStyleBackColor = true;
            this.bt_historique.Click += new System.EventHandler(this.button1_Click);
            // 
            // fm_sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 340);
            this.Controls.Add(this.bt_historique);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_commencer);
            this.Controls.Add(this.lb_triche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_mesScores);
            this.Controls.Add(this.bt_pause);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fm_sudoku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku cs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sudoku_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mesScores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSolution;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button bt_pause;
        private System.Windows.Forms.DataGridView dgv_mesScores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_triche;
        private System.Windows.Forms.Button bt_commencer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_penalite;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.Label lb_pseudo;
        private System.Windows.Forms.Label lb_totalTemps;
        private System.Windows.Forms.Label lb_tpTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_historique;
    }
}

