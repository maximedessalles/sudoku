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
using System.Timers;
using sudoku_cs;
using Timer = System.Windows.Forms.Timer;

namespace sudoku
{
    public partial class fm_login : Form
    {
        public fm_login()
        {
            InitializeComponent();
            

        }




        private void login_Load(object sender, EventArgs e)
        {
            List<Resultat> Les10Resultats = new List<Resultat>();
            lb_erreur.Visible = false;
            Les10Resultats = resultatService.get10Resultats();
            
            foreach(Resultat unR in Les10Resultats)
            {
                Utilisateur monUtilisateur = utilisateurService.GetUtilisateurById(unR.Utilisateur);
                unR.Pseudo = monUtilisateur.Pseudo;
                int minutes = int.Parse(unR.Temps)/60;
                int secondes = int.Parse(unR.Temps) % 60;
                string temps = minutes.ToString() + "m : " + secondes.ToString() + "s";
                unR.Temps = temps;
            }
            dgv_10scores.DataSource = Les10Resultats;
            dgv_10scores.Columns["Id"].Visible = false;
            dgv_10scores.Columns["Utilisateur"].Visible = false;
            dgv_10scores.Columns["Date"].Visible = false;
            dgv_10scores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_10scores.ReadOnly = true;
            dgv_10scores.RowHeadersVisible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_connexion_Click(object sender, EventArgs e)
        {

            string pseudo = tb_login.Text;
            if (pseudo == "")
            {
                lb_erreur.Text = "Vous ne pouvez pas choisir ce pseudo.";
                lb_erreur.Visible = true;
            }
            else
            {
                Utilisateur monUser = new Utilisateur();
                monUser = utilisateurService.GetUtilisateur(pseudo);
                if (monUser.Pseudo == null)
                {
                    utilisateurService.addUtilisateur(pseudo);
                    monUser = utilisateurService.GetUtilisateur(pseudo);
                }
                this.Hide();
                sudoku_cs.fm_sudoku monSudoku = new sudoku_cs.fm_sudoku(monUser);
                monSudoku.Show();
            } 
        }
    }
}
