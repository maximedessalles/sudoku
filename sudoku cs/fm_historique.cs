using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;
namespace sudoku_cs
{
    public partial class fm_historique : Form
    {
        Utilisateur monUser;
        public fm_historique(Utilisateur monUtilisateur)
        {
            InitializeComponent();
            monUser = monUtilisateur;
        }

        private void fm_historique_Load(object sender, EventArgs e)
        {

            this.Location= new Point(fm_sudoku.ActiveForm.Location.X+fm_sudoku.ActiveForm.Size.Width, fm_sudoku.ActiveForm.Location.Y);
            
            cb_difficulte.SelectedIndex = 0;
            DataGridView1.Rows.Add(9);
            DataGridView1.AllowUserToResizeRows = false;
            DataGridView1.AllowUserToResizeColumns = false;
            List<Resultat> mesParties = new List<Resultat>();
            mesParties = resultatService.getMesResultats(monUser.Id);
            foreach(Resultat unR in mesParties)
            {
                cb_mesParties.Items.Add(unR);
            }
            if (mesParties.Count > 0)
            {
                cb_mesParties.SelectedIndex = 0;
                cb_mesParties.DisplayMember = "Date";
                cb_mesParties.ValueMember = "Date";
                lb_error.Visible = false;
            }
            else
            {
                lb_error.Visible = true;
                cb_mesParties.Visible = false;
                DataGridView1.Visible = false;
                lb_temps.Visible = false;
                lb_difficulte.Visible = false;
            }
            
            


        }

       

        private void DataGridView1_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 75, 0, 75, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 150, 0, 150, 228);

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 66, 228, 66);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 132, 228, 132);
        }

        private void cb_mesParties_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_mesParties.SelectedIndex != -1)
            {
                int x=0;
                string temp = "";
                int y=0;
                char[,] grid = new char[9,9];
                historique monH = new historique();
                Resultat monR = (Resultat)cb_mesParties.SelectedItem;
                
                monH = historiqueService.getMaPartie(monR.Id);
                lb_temps.Text = int.Parse(monR.Temps)/60+":"+int.Parse(monR.Temps)%60;
                lb_difficulte.Text = monH.Difficulte;
                for (int i=0;i<monH.Numero.Length;i++)
                {
                        grid[y, x] = monH.Numero[i];
                        DataGridView1.Rows[y].Cells[x].Value = monH.Numero[i];
                    if (monH.NumeroIndice[i] == '1')
                    {
                        DataGridView1.Rows[y].Cells[x].Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        DataGridView1.Rows[y].Cells[x].Style.ForeColor = Color.Blue;
                    }
                    if (x == 8)
                    {
                        y++;
                        x = 0;
                    }
                    else
                    {
                        x++;
                    }
                }
            }
        }

        private void bt_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initChart(string difficulte)
        {
            chart_stat.Series["stat"].Points.Clear();
            chart_stat.Titles.Clear();
            int nbPartie;


            historique unH = new historique();
            List<Resultat> mesParties = new List<Resultat>();
            mesParties = resultatService.getMesResultats(monUser.Id);
            List<Resultat> mesPartiesAvecDifficulte = new List<Resultat>();
            foreach(Resultat unR in mesParties)
            {
                unH = historiqueService.getMaPartie(unR.Id);
                if (unH.Difficulte == difficulte)
                {
                    mesPartiesAvecDifficulte.Add(unR);
                }
            }

            nbPartie = mesPartiesAvecDifficulte.Count();
            if (nbPartie != 0)
            {
                chart_stat.Titles.Add("Statistique de mes parties ["+nbPartie+" jouées]");
                lb_nbPartie.Visible = false;
                int nb1 = 0;
                int nb2 = 0;
                int nb3 = 0;
                int nb4 = 0;
                int nb5 = 0;
                int nb6 = 0;
                int monTemps = 0;
                foreach (Resultat unR in mesPartiesAvecDifficulte)
                {
                    monTemps = int.Parse(unR.Temps) / 60;
                    if (monTemps >= 0 && monTemps < 2)
                        nb1++;
                    if (monTemps >= 2 && monTemps < 4)
                        nb2++;
                    if (monTemps >= 4 && monTemps < 6)
                        nb3++;
                    if (monTemps >= 6 && monTemps < 8)
                        nb4++;
                    if (monTemps >= 8 && monTemps < 10)
                        nb5++;
                    if (monTemps >= 10)
                        nb6++;
                }

                if (nb1 > 0)
                    chart_stat.Series["stat"].Points.AddXY("0-2m["+nb1+"]", nb1);
                if (nb2 > 0)
                    chart_stat.Series["stat"].Points.AddXY("2-4m[" + nb2 + "]", nb2);
                if (nb3 > 0)
                    chart_stat.Series["stat"].Points.AddXY("4-6m[" + nb3 + "]", nb3);
                if (nb4 > 0)
                    chart_stat.Series["stat"].Points.AddXY("6-8m[" + nb4 + "]", nb4);
                if (nb5 > 0)
                    chart_stat.Series["stat"].Points.AddXY("8-10m[" + nb5 + "]", nb5);
                if (nb6 > 0)
                    chart_stat.Series["stat"].Points.AddXY(">10m[" + nb6 + "]", nb6);
            }
            else lb_nbPartie.Visible = true;
                    
        }

        private void cb_difficulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            initChart(cb_difficulte.Text.ToString());
        }
    }
    
}
