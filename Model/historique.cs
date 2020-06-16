using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class historique
    {
        private Guid id;
        private string numero;
        private Guid resultat;
        private string numeroIndice;
        private string difficulte;

        public Guid Resultat { get => resultat; set => resultat = value; }
        public string Numero { get => numero; set => numero = value; }
        public Guid Id { get => id; set => id = value; }
        public string Difficulte { get => difficulte; set => difficulte = value; }
        public string NumeroIndice { get => numeroIndice; set => numeroIndice = value; }

        public historique(Guid id, string numero, Guid resultat, string numeroindice)
        {
            this.Resultat = resultat;
            this.NumeroIndice = numeroindice;
            this.Numero = numero;
            this.Id = id;
            this.Difficulte = difficulte;
        }

        public historique() { }
    }
}
