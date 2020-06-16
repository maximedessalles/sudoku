namespace sudoku_cs
{
    partial class fm_historique
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_mesParties = new System.Windows.Forms.ComboBox();
            this.lb_difficulte = new System.Windows.Forms.Label();
            this.lb_temps = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.bt_retour = new System.Windows.Forms.Button();
            this.chart_stat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cb_difficulte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_nbPartie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stat)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
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
            this.DataGridView1.Location = new System.Drawing.Point(12, 108);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(228, 201);
            this.DataGridView1.TabIndex = 6;
            this.DataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.DataGridView1_Paint_1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "HISTORIQUE DES PARTIES";
            // 
            // cb_mesParties
            // 
            this.cb_mesParties.FormattingEnabled = true;
            this.cb_mesParties.Location = new System.Drawing.Point(12, 41);
            this.cb_mesParties.Name = "cb_mesParties";
            this.cb_mesParties.Size = new System.Drawing.Size(228, 21);
            this.cb_mesParties.TabIndex = 8;
            this.cb_mesParties.SelectedIndexChanged += new System.EventHandler(this.cb_mesParties_SelectedIndexChanged_1);
            // 
            // lb_difficulte
            // 
            this.lb_difficulte.AutoSize = true;
            this.lb_difficulte.Location = new System.Drawing.Point(9, 75);
            this.lb_difficulte.Name = "lb_difficulte";
            this.lb_difficulte.Size = new System.Drawing.Size(48, 13);
            this.lb_difficulte.TabIndex = 9;
            this.lb_difficulte.Text = "Difficulte";
            // 
            // lb_temps
            // 
            this.lb_temps.AutoSize = true;
            this.lb_temps.Location = new System.Drawing.Point(201, 75);
            this.lb_temps.Name = "lb_temps";
            this.lb_temps.Size = new System.Drawing.Size(39, 13);
            this.lb_temps.TabIndex = 10;
            this.lb_temps.Text = "Temps";
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Location = new System.Drawing.Point(9, 26);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(243, 13);
            this.lb_error.TabIndex = 11;
            this.lb_error.Text = "Vous n\'avez pas encore de parties sauvegardées.";
            // 
            // bt_retour
            // 
            this.bt_retour.Location = new System.Drawing.Point(12, 315);
            this.bt_retour.Name = "bt_retour";
            this.bt_retour.Size = new System.Drawing.Size(602, 23);
            this.bt_retour.TabIndex = 12;
            this.bt_retour.Text = "RETOUR";
            this.bt_retour.UseVisualStyleBackColor = true;
            this.bt_retour.Click += new System.EventHandler(this.bt_retour_Click);
            // 
            // chart_stat
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_stat.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_stat.Legends.Add(legend4);
            this.chart_stat.Location = new System.Drawing.Point(258, 75);
            this.chart_stat.Name = "chart_stat";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "stat";
            this.chart_stat.Series.Add(series4);
            this.chart_stat.Size = new System.Drawing.Size(356, 234);
            this.chart_stat.TabIndex = 13;
            this.chart_stat.Text = "chart1";
            // 
            // cb_difficulte
            // 
            this.cb_difficulte.FormattingEnabled = true;
            this.cb_difficulte.Items.AddRange(new object[] {
            "Facile",
            "Moyen",
            "Difficile"});
            this.cb_difficulte.Location = new System.Drawing.Point(383, 41);
            this.cb_difficulte.Name = "cb_difficulte";
            this.cb_difficulte.Size = new System.Drawing.Size(231, 21);
            this.cb_difficulte.TabIndex = 14;
            this.cb_difficulte.SelectedIndexChanged += new System.EventHandler(this.cb_difficulte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Difficulté de mes parties ";
            // 
            // lb_nbPartie
            // 
            this.lb_nbPartie.AutoSize = true;
            this.lb_nbPartie.Location = new System.Drawing.Point(301, 178);
            this.lb_nbPartie.Name = "lb_nbPartie";
            this.lb_nbPartie.Size = new System.Drawing.Size(251, 13);
            this.lb_nbPartie.TabIndex = 16;
            this.lb_nbPartie.Text = "Vous n\'avez pas joué de partie avec cette difficulte.";
            // 
            // fm_historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 340);
            this.Controls.Add(this.lb_nbPartie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_difficulte);
            this.Controls.Add(this.chart_stat);
            this.Controls.Add(this.bt_retour);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.lb_temps);
            this.Controls.Add(this.lb_difficulte);
            this.Controls.Add(this.cb_mesParties);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView1);
            this.Name = "fm_historique";
            this.Text = "historique";
            this.Load += new System.EventHandler(this.fm_historique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_mesParties;
        private System.Windows.Forms.Label lb_difficulte;
        private System.Windows.Forms.Label lb_temps;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.Button bt_retour;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_stat;
        private System.Windows.Forms.ComboBox cb_difficulte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_nbPartie;
    }
}