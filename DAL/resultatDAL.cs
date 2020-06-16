using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class resultatDAL
    {
        public static string getDbConnexion()
        {
            return "Integrated Security=SSPI;Persist Security Info=False;User ID=app_etohub;Initial Catalog=sudoku;Data Source=asus-maxime";
        }
        public static void addResultat(Resultat monResultat)
        {

            SqlConnection sqlConnection1 = new SqlConnection(getDbConnexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            
            cmd.CommandText = "INSERT INTO [dbo].[sudoku_resultat] VALUES ('" + monResultat.Id + "','" + monResultat.Temps +"','"+monResultat.Utilisateur +"','"+monResultat.Date+"')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;



            sqlConnection1.Open();

            reader = cmd.ExecuteReader();

           


            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();
        }

        public static List<Resultat> get10Resultats()
        {
            List<Resultat> mesResultats= new List<Resultat>();
            Utilisateur monUtilisateur = new Utilisateur();
            SqlConnection sqlConnection1 = new SqlConnection(getDbConnexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select TOP 10 * from [dbo].[sudoku_resultat] order by temps";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Resultat monResultat = new Resultat();
                monResultat.Id = (Guid)reader[0];
                monResultat.Temps = reader[1].ToString();
                monResultat.Utilisateur = (Guid)reader[2];
            

                mesResultats.Add(monResultat);
            }

            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();


            return mesResultats;
        }

        public static List<Resultat> getMesResultats(Guid id)
        {
            List<Resultat> mesResultats = new List<Resultat>();
            Utilisateur monUtilisateur = new Utilisateur();
            SqlConnection sqlConnection1 = new SqlConnection(getDbConnexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select TOP 10 * from [dbo].[sudoku_resultat] where utilisateur ='"+id+ "' order by temps";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Resultat monResultat = new Resultat();
                monResultat.Id = (Guid)reader[0];
                monResultat.Temps = reader[1].ToString();
                monResultat.Utilisateur = (Guid)reader[2];
                monResultat.Date = reader[3].ToString();

                mesResultats.Add(monResultat);
            }

            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();


            return mesResultats;
        }

        public static Resultat getMeilleurResultat(Guid id)
        {
            Resultat meilleurResultat = new Resultat();
            Utilisateur monUtilisateur = new Utilisateur();
            SqlConnection sqlConnection1 = new SqlConnection(getDbConnexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select * from [dbo].[sudoku_Resultat] where temps = (Select max(temps) from [dbo].[sudoku_resultat] where utilisateur='"+id+"') AND utilisateur ='" + id +"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                meilleurResultat.Id = (Guid)reader[0];
                meilleurResultat.Temps = reader[1].ToString();
                meilleurResultat.Utilisateur = (Guid)reader[2];

            }

            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();


            return meilleurResultat;
        }
    }
}
