using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class utilisateurService
    {
        public static Utilisateur GetUtilisateur(string pseudo)
        {
            Utilisateur monUtilisateur = new Utilisateur();
            monUtilisateur = utilisateurDAL.getUtilisateur(pseudo);
            return monUtilisateur;
        }
        public static void addUtilisateur(string pseudo)
        {
            Utilisateur monUser = new Utilisateur();
            monUser.Pseudo = pseudo;
            utilisateurDAL.addUtilisateur(monUser);
        }
        public static Utilisateur GetUtilisateurById(Guid Id)
        {
            Utilisateur monUtilisateur = new Utilisateur();
            monUtilisateur = utilisateurDAL.getUtilisateurByid(Id);
            return monUtilisateur;
        }
        
    }
}
