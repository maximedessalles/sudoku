using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class historiqueService
    {
        public static void addHistorique(string numero, Guid resultat,string difficulte,string numeroindice)
        {
            historique maPartie = new historique();
            maPartie.Id = new Guid();
            maPartie.Id= Guid.NewGuid();
            maPartie.Difficulte = difficulte;
            maPartie.NumeroIndice = numeroindice;
            maPartie.Resultat = resultat;
            maPartie.Numero = numero;

            
            historiqueDAL.addHistorique(maPartie);
        }

        public static historique getMaPartie(Guid resultat)
        {
            historique monHistorique = new historique();
            monHistorique = historiqueDAL.getMonResultat(resultat);
            return monHistorique;
        }


    }
}
