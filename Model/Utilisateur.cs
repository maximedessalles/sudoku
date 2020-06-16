using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Utilisateur
    {
        private Guid _id;
        private string pseudo;

        public string Pseudo { get => pseudo; set => pseudo = value; }
        public Guid Id { get => _id; set => _id = value; }

        public Utilisateur()
        {

        }

        public Utilisateur(Guid Id)
        {
            this.Id = Id;
        }

        public Utilisateur(Guid Id,string pseudo)
        {
            this.Id = Id;
            this.Pseudo = pseudo;
        }
    }
}
