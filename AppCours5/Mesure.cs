using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCours5
{
    public class Mesure
    {
        public float Poids { get; set; }
        public float Taille { get; set; }
        public Mesure(float poids, float taille)
        {
            Poids = poids;
            Taille = taille;
        }
        public float IMC()
        {
            return Poids / (Taille * Taille);
        }
    }
}
