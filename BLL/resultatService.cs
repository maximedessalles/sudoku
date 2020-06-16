using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;
using System.Threading.Tasks;

namespace BLL
{
    public class resultatService
    {
        public static List<Resultat> get10Resultats()
        {
            List<Resultat> mesResultats = new List<Resultat>();
            mesResultats = resultatDAL.get10Resultats();
            return mesResultats;
        }

        public static List<Resultat> getMesResultats(Guid id)
        {
            List<Resultat> mesResultats = new List<Resultat>();
            mesResultats = resultatDAL.getMesResultats(id);
            return mesResultats;
        }

        public static Resultat getmeilleurResultat(Guid id)
        {
            Resultat meilleurResultat = new Resultat();
            meilleurResultat = resultatDAL.getMeilleurResultat(id);
            return meilleurResultat;
        }

        public static void addResultat(Resultat monR)
        {
            monR.Date = DateTime.Now.ToString();
            resultatDAL.addResultat(monR);
        }

    }
}
