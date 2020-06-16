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
    public class historiqueDAL
    {
        public static string getDbConnexion()
        {
            return "Integrated Security=SSPI;Persist Security Info=False;User ID=app_etohub;Initial Catalog=sudoku;Data Source=asus-maxime";
        }

        public static void addHistorique(historique monH)
        {
            SqlConnection sqlConnection1 = new SqlConnection(getDbConnexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "INSERT INTO [dbo].[sudoku_historique] VALUES ('" + monH.Id + "','" + monH.Numero + "','" + monH.Resultat + "','"+monH.Difficulte+"','"+monH.NumeroIndice+"')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;



            sqlConnection1.Open();

            reader = cmd.ExecuteReader();




            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();
        }

        public static historique getMonResultat(Guid Resultat)
        {
            historique monH = new historique();
            SqlConnection sqlConnection1 = new SqlConnection(getDbConnexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select * from [dbo].[sudoku_historique] where resultat ='"+Resultat+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                monH.Id = (Guid)reader[0];
                monH.Numero = reader[1].ToString();
                monH.Resultat = (Guid)reader[2];
                monH.Difficulte = reader[3].ToString();
                monH.NumeroIndice = reader[4].ToString();
            }

            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();


            return monH;
        }
    }
}
