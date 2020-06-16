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
    public class utilisateurDAL
    {
        public static string getDbConnexion()
        {
            return "Integrated Security=SSPI;Persist Security Info=False;User ID=app_etohub;Initial Catalog=sudoku;Data Source=asus-maxime";
        }
        public static Utilisateur getUtilisateur(string pseudo)
        {
            Utilisateur monUtilisateur = new Utilisateur();

            SqlConnection sqlConnection1 = new SqlConnection(getDbConnexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select TOP 1 * from [dbo].[Utilisateur] WHERE pseudo = '"+pseudo+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    monUtilisateur.Id = (Guid)reader[0];
                    monUtilisateur.Pseudo = reader[1].ToString();
                }
            } catch
            {
                monUtilisateur.Id = new Guid();
                monUtilisateur.Pseudo = null;
            }
            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();


            return monUtilisateur;
        }

        public static Utilisateur getUtilisateurByid(Guid Id)
        {
            Utilisateur monUtilisateur = new Utilisateur();

            SqlConnection sqlConnection1 = new SqlConnection(getDbConnexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select TOP 1 * from [dbo].[Utilisateur] WHERE utilisateur_id ='" + Id + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    monUtilisateur.Id = (Guid)reader[0];
                    monUtilisateur.Pseudo = reader[1].ToString();
                }
            }
            catch
            {
                monUtilisateur.Id = new Guid();
                monUtilisateur.Pseudo = null;
            }
            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();


            return monUtilisateur;
        }
        public static void addUtilisateur(Utilisateur monUtilisateur)
        {
            monUtilisateur.Id = Guid.NewGuid();

            SqlConnection sqlConnection1 = new SqlConnection(getDbConnexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "INSERT INTO [dbo].[Utilisateur] VALUES ('" + monUtilisateur.Id + "','" + monUtilisateur.Pseudo + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;



            sqlConnection1.Open();

            reader = cmd.ExecuteReader();


            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();
        }
    }
}
