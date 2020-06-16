using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;
using System.Collections;

namespace sudoku_cs
{
    public partial class fm_sudoku : Form
    {
        private List<string> tableauChiffre = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
        private Game game = new Game();
        private int secondes = 0;
        private int minutes = 0;
        private int penalite = 0;
        private Utilisateur monUser;
        Timer Clock = new Timer();

        private Random r = new Random();

        

        public fm_sudoku(Utilisateur monUtilisateur)
        {
            InitializeComponent();
            
            btnNew.Click += btnNew_Click;
            DataGridView1.Paint += DataGridView1_Paint;
            ComboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            game.ShowClues += game_ShowClues;
            game.ShowSolution += game_ShowSolution;
            this.monUser = monUtilisateur;
            lb_pseudo.Text = "Pseudo : " + monUser.Pseudo;
        }

        public void setTimer()
        {
            
            Clock.Start();
            
        }

        public void Timer_Tick(object sender, EventArgs eArgs)
        {
            secondes++;
            if (secondes > 60)
            {
                minutes++;
                secondes -=60;
            }
            lb_timer.Text = minutes.ToString() + ":" + secondes.ToString();
        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            lb_tpTotal.Visible = false;
            lb_totalTemps.Visible = false;
            DataGridView1.Rows.Add(9);
            DataGridView1.AllowUserToResizeRows = false;
            DataGridView1.AllowUserToResizeColumns = false;
            dgv_mesScores.AllowUserToResizeRows = false;
            dgv_mesScores.AllowUserToResizeColumns = false;
            ComboBox1.SelectedIndex = 0;
            btnNew.PerformClick();
            Clock.Interval = 1000;
            Clock.Tick += new EventHandler(Timer_Tick);

            List<Resultat> mesResultats = new List<Resultat>();
            mesResultats = resultatService.getMesResultats(monUser.Id);

            foreach (Resultat unR in mesResultats)
            {
                Utilisateur monUtilisateur = utilisateurService.GetUtilisateurById(unR.Utilisateur);
                unR.Pseudo = monUtilisateur.Pseudo;
                int minutes = int.Parse(unR.Temps) / 60;
                int secondes = int.Parse(unR.Temps) % 60;
                string temps = minutes.ToString() + "m : " + secondes.ToString() + "s";
                unR.Temps = temps;
            }
            dgv_mesScores.DataSource = mesResultats;
            dgv_mesScores.Columns["Id"].Visible = false;
            dgv_mesScores.Columns["Utilisateur"].Visible = false;
            dgv_mesScores.Columns["Pseudo"].Visible = false;
            dgv_mesScores.AutoSize = true;
            dgv_mesScores.Columns["Temps"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_mesScores.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_mesScores.Columns["Temps"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; ;
            dgv_mesScores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_mesScores.RowHeadersVisible = false;
            lb_triche.Visible = false;
            DataGridView1.Visible = false;
            btnSolution.Visible = false;
            bt_pause.Visible = false;
            btnNew.Visible = false;
            dgv_mesScores.ReadOnly = true;
            
        }

        private void btnNew_Click(System.Object sender, System.EventArgs e)
        {
            penalite = 0;
            lb_penalite.Text = penalite.ToString() + "s";
            bt_pause.Text = "Pause";
            btnSolution.Enabled = true;
            lb_triche.Visible = false;
            game.NewGame(r);
            Clock.Stop();
            lb_timer.Text = "m:s";
            DataGridView1.Visible = false;
            bt_commencer.Visible = true;
            btnSolution.Visible = false;
            bt_pause.Visible = false;
            btnNew.Visible = false;
            for (int y = 0; y <= 8; y++)
            {
                for (int x = 0; x <= 8; x++)
                {
                            DataGridView1.Rows[y].Cells[x].Style.BackColor = Color.White;

                }
            }

        }

        private void DataGridView1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 75, 0, 75, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 150, 0, 150, 228);
            
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 66, 228, 66);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 132, 228, 132);
        }

        private void btnSolution_Click(System.Object sender, System.EventArgs e)
        {
            Clock.Stop();
            game.showGridSolution();
        }

        private void ComboBox1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            btnNew.PerformClick();
        }

        public void game_ShowClues(int[][] grid)
        {
            for (int y = 0; y <= 8; y++)
            {
                List<int> cells = new List<int>(new int[] {1,2,3,4,5,6,7,8,9});
                for (int c = 1; c <= 9 - (5 - ComboBox1.SelectedIndex); c++)
                {
                    int randomNumber = cells[r.Next(0, cells.Count())];
                    cells.Remove(randomNumber);
                }
                for (int x = 0; x <= 8; x++)
                {
                    if (cells.Contains(x + 1))
                    {
                        DataGridView1.Rows[y].Cells[x].Value = grid[y][x];
                        DataGridView1.Rows[y].Cells[x].Style.ForeColor = Color.Black;
                        DataGridView1.Rows[y].Cells[x].ReadOnly = true;
                    }
                    else
                    {
                        DataGridView1.Rows[y].Cells[x].Value = "";
                        DataGridView1.Rows[y].Cells[x].Style.ForeColor = Color.Blue;
                        DataGridView1.Rows[y].Cells[x].ReadOnly = false;
                    }
                }
            }
        }


        public void majDgv()
        {
            List<Resultat> mesResultats = new List<Resultat>();
            mesResultats = resultatService.getMesResultats(monUser.Id);

            foreach (Resultat unR in mesResultats)
            {
                Utilisateur monUtilisateur = utilisateurService.GetUtilisateurById(unR.Utilisateur);
                unR.Pseudo = monUtilisateur.Pseudo;
                int minutes = int.Parse(unR.Temps) / 60;
                int secondes = int.Parse(unR.Temps) % 60;
                string temps = minutes.ToString() + "m : " + secondes.ToString() + "s";
                unR.Temps = temps;
            }
            dgv_mesScores.DataSource = mesResultats;
            dgv_mesScores.Columns["Id"].Visible = false;
            dgv_mesScores.Columns["Utilisateur"].Visible = false;
            dgv_mesScores.Columns["Pseudo"].Visible = false;
        }



        public void game_ShowSolution(int[][] grid)
        {
            
            bool resultat = true;
            string numero = "";
            bool resultat2 = true;
            string numeroindice = "";
            resultat = game_verifColonne()&game_verifLigne()&game_verifValeur();
            resultat2 = game_verifSquare();
            resultat = resultat && resultat2;   
            
            if (resultat)
            {
                int temps = minutes * 60 + secondes + penalite;
                Resultat monR = new Resultat();
                Resultat meilleurResultat = new Resultat();
                meilleurResultat = resultatService.getmeilleurResultat(monUser.Id);
                if (meilleurResultat.Temps != null)
                {

                    if (temps < int.Parse(meilleurResultat.Temps))
                    {
                        MessageBox.Show("Bravo , vous venez de battre votre propre record !");
                    }
                }
                monR.Id = new Guid();
                monR.Id = Guid.NewGuid();
                lb_totalTemps.Visible = true;
                lb_tpTotal.Visible = true;
                lb_totalTemps.Text = (temps / 60).ToString() + ":" + (temps % 60).ToString();
                monR.Utilisateur = monUser.Id;
                monR.Temps = temps.ToString();
                for (int y = 0; y <= 8; y++)

                {
                    for (int x = 0; x <= 8; x++)
                    {
                        numero = numero + grid[y][x].ToString();
                        if (DataGridView1.Rows[y].Cells[x].Style.ForeColor == Color.Black)
                        {
                            numeroindice = numeroindice + "1";
                           
                        }
                        else
                        {
                            
                            numeroindice = numeroindice + "0";
                        }
                        
                    }

                }
                historiqueService.addHistorique(numero,monR.Id, ComboBox1.Text.ToString(),numeroindice);
                resultatService.addResultat(monR);
                this.majDgv();
            }
            else
            {
                Clock.Start();
                penalite += 20;
                lb_penalite.Text = penalite.ToString() + "s";
                MessageBox.Show("20 secondes de pénalité pour avoir utiliser la vérification en ayant des erreurs.");
            }
        }

        public bool game_verifLigne()
        {
            List<int> ligne = new List<int>(new int[] {});
            int colonne;
            bool resultat = true; ;
            for (int y = 0; y <= 8; y++)
            {
                for (int x = 0; x <= 8; x++)
                {
                    if (string.IsNullOrEmpty(DataGridView1.Rows[y].Cells[x].Value.ToString()))
                    {
                        ligne.Add(0);
                        DataGridView1.Rows[y].Cells[x].Style.BackColor = Color.Red;
                        resultat = false;
                    }
                    else
                    {
                        if (!tableauChiffre.Contains(DataGridView1.Rows[y].Cells[x].Value.ToString()))
                        {
                            resultat = false;
                            DataGridView1.Rows[y].Cells[x].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            if (ligne.Contains(int.Parse(DataGridView1.Rows[y].Cells[x].Value.ToString())))
                            {
                                DataGridView1.Rows[y].Cells[x].Style.BackColor = Color.Red;
                                colonne = ligne.IndexOf(int.Parse(DataGridView1.Rows[y].Cells[x].Value.ToString()));
                                DataGridView1.Rows[y].Cells[colonne].Style.BackColor = Color.Red;
                                resultat = false;

                            }
                            else
                            {
                                ligne.Add(int.Parse(DataGridView1.Rows[y].Cells[x].Value.ToString()));
                            }

                        }
                    }
                }
                ligne.Clear();
            }
            return resultat;
        }

        public bool game_verifValeur()
        {
            int valeur;
            bool resultat = true; ;
            for (int y = 0; y <= 8; y++)
            {
                for (int x = 0; x <= 8; x++)
                {
                    
                    if (string.IsNullOrEmpty(DataGridView1.Rows[y].Cells[x].Value.ToString()))
                    {
                        resultat = false;
                        DataGridView1.Rows[y].Cells[x].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        if (!tableauChiffre.Contains(DataGridView1.Rows[y].Cells[x].Value.ToString()))
                        {
                            resultat = false;
                            DataGridView1.Rows[y].Cells[x].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            valeur = int.Parse(DataGridView1.Rows[y].Cells[x].Value.ToString());
                            if (valeur != 1 && valeur != 2 && valeur != 3 && valeur != 4 && valeur != 5 && valeur != 6 && valeur != 7 && valeur != 8 && valeur != 9)
                            {
                                resultat = false;
                                DataGridView1.Rows[y].Cells[x].Style.BackColor = Color.Red;
                            }
                        }
                    }
                    
                }
            }
            return resultat;
        }



        public bool game_verifColonne()
        {

            List<int> colonne = new List<int>(new int[] { });
            int row;
            bool resultat = true; ;
            for (int y = 0; y <= 8; y++)
            {
                for (int x = 0; x <= 8; x++)
                {
                    if (string.IsNullOrEmpty(DataGridView1.Rows[x].Cells[y].Value.ToString()))
                    {
                        colonne.Add(0);
                        DataGridView1.Rows[x].Cells[y].Style.BackColor = Color.Red;
                        resultat = false;
                    }
                    else
                    {
                        if (!tableauChiffre.Contains(DataGridView1.Rows[x].Cells[y].Value.ToString()))
                        {
                            resultat = false;
                            DataGridView1.Rows[x].Cells[y].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            if (colonne.Contains(int.Parse(DataGridView1.Rows[x].Cells[y].Value.ToString())))
                            {
                                DataGridView1.Rows[x].Cells[y].Style.BackColor = Color.Red;
                                row = colonne.IndexOf(int.Parse(DataGridView1.Rows[x].Cells[y].Value.ToString()));
                                DataGridView1.Rows[row].Cells[y].Style.BackColor = Color.Red;
                                resultat = false;

                            }
                            else
                            {
                                colonne.Add(int.Parse(DataGridView1.Rows[x].Cells[y].Value.ToString()));
                            }

                        }
                    }
                }
                colonne.Clear();
            }
            return resultat;
        }

        public bool game_verifSquare()
        {
            List<coordonne> mesValeurs = new List<coordonne>();
            List<int> ligne = new List<int>(new int[] { });
            bool resultat = true;
            int maxCol = 2;
            int maxLigne = 2;
            int initLigne = 0;
            int initCol = 0;
            for (int a = 0; a <= 8; a++)
            {
                for (int x = initCol; x <= maxCol; x++)
                {
                    for (int y = initLigne; y <= maxLigne; y++)
                    {
                        if (string.IsNullOrEmpty(DataGridView1.Rows[y].Cells[x].Value.ToString()))
                        {
                            mesValeurs.Add(new coordonne("0", x, y));
                            resultat = false;
                        }
                        else
                        {
                            if (!tableauChiffre.Contains(DataGridView1.Rows[y].Cells[x].Value.ToString()))
                            {
                                resultat = false;
                            }
                            else
                            {
                                
                                foreach (coordonne uneV in mesValeurs)
                                {
                                    if(int.Parse(uneV.Valeur) == int.Parse(DataGridView1.Rows[y].Cells[x].Value.ToString()))
                                    {
                                        DataGridView1.Rows[y].Cells[x].Style.BackColor = Color.Red;
                                        DataGridView1.Rows[uneV.Y].Cells[uneV.X].Style.BackColor = Color.Red;
                                        resultat = false;
                                    }
                                    else
                                    {
                                        
                                    }
                                }
                                mesValeurs.Add(new coordonne(DataGridView1.Rows[y].Cells[x].Value.ToString(), x, y));
                            }
                        }
                    }
                    
                }
                if (initLigne == 6)
                {
                    initLigne = 0;
                    maxLigne = 2;
                    initCol += 3;
                    maxCol += 3;
                }
                else
                {
                    initLigne += 3;
                    maxLigne += 3;
                    
                }

                mesValeurs.Clear();
            }
            return resultat;
        }






        private void bt_pause_Click(object sender, EventArgs e)
        {
            if (bt_pause.Text == "Pause")
            {
                penalite += 5;
                lb_penalite.Text = penalite.ToString()+"s";
                Clock.Stop();
                bt_pause.Text = "Reprendre";
                DataGridView1.Visible = false;
                lb_triche.Visible = true;
                btnSolution.Enabled = false;
                lb_triche.Text = "Hop Hop Hop ! Pas de tricherie !";
                

                MessageBox.Show("5 secondes de pénalité pour avoir mis le jeu en pause.");
                
            }
            else
            {
                btnSolution.Enabled = true;
                Clock.Start();
                bt_pause.Text = "Pause";
                DataGridView1.Visible = true;
                lb_triche.Visible = false;
            }
        }



        private void sudoku_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }





        private void bt_commencer_Click(object sender, EventArgs e)
        {
            minutes = 0;
            secondes = 0;
            DataGridView1.Visible = true;
            bt_commencer.Visible = false;
            setTimer();
            btnSolution.Visible = true;
            bt_pause.Visible = true;
            btnNew.Visible = true;
            lb_totalTemps.Visible = false;
            lb_tpTotal.Visible = false;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            fm_historique fm_historique = new fm_historique(monUser);
            fm_historique.ShowDialog();
        }


    }
}
