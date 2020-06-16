using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class coordonne
    {
        private string valeur;
        private int x;
        private int y;

        public string Valeur { get => valeur; set => valeur = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        
        public coordonne(string valeur,int x,int y)
        {
            this.Valeur = valeur;
            this.X = x;
            this.Y = y;
        }
    }
}
