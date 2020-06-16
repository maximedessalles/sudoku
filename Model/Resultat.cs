using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Resultat
    {
        private Guid _id;
        private Guid utilisateur;
        private string temps;
        private string date;
        private string pseudo;

        

        public string Temps { get => temps; set => temps = value; }
        public Guid Utilisateur { get => utilisateur; set => utilisateur = value; }
        public Guid Id { get => _id; set => _id = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }
        public string Date { get => date; set => date = value; }

      

        public Resultat()
        {

        }

        public Resultat(Guid id)
        {
            this.Id = id;
        }

        public Resultat(Guid id , Guid utilsateur)
        {
            this.Id = id;
            this.Utilisateur = utilisateur;
        }

        public Resultat(Guid id , Guid utilsiateur , string temps)
        {
            this.Id = id;
            this.Utilisateur = utilisateur;
            this.Temps = temps;
        }
    }
}
