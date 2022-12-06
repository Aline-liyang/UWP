using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval3GroupeYongjiangEtLi
{
    public class Voyageur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public string DateNaissance{ get; set; }
        public string NumeroPasseport { get; set; }
        public string Dateechence { get; set; }
       

        public Voyageur()
        {
            Nom = "";
            Prenom = "";
            Sexe = "";
            DateNaissance = "";
            NumeroPasseport = "";
            Dateechence = "";
            
        }




        public Voyageur(String nom, String prenom,String sexe,String datenaissance, String numeropasseport,String dateechence)
        {
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            DateNaissance = datenaissance;
            NumeroPasseport = numeropasseport;
            Dateechence = dateechence;
            
        }  
        



    }
}
