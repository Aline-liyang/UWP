using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval4LY
{
    class Centre
    {
        public string Nom { get; set; }
        public string Categorie { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }

        public Centre(String nom, String categorie, string image1, string image2, string image3)
        {
            Nom = nom;
            Categorie = categorie;
            Image1 = image1;
            Image2 = image2;
            Image3 = image3;

        }
    }
}


