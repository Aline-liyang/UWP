using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppCours5
{
    public class MesureNPC : INotifyPropertyChanged // interface pour implémenter le mécanisme de notification entre la classe et l’interface utilisateur
    {
        private float poids;
        private float taille;
        private float imc;
        // à Chaque modification du poids on recalcule la valeur de l’IMC
        public float Poids { get { return poids; } set { poids = value; OnPropertyChanged("Poids"); Calculer(); } }
        public float Taille { get { return taille; } set { taille = value; OnPropertyChanged("Taille"); Calculer(); } }
        public float IMC { get { return imc; } set { imc = value; OnPropertyChanged("IMC"); } }
        public MesureNPC(float poids, float taille)
        {
            this.poids = poids;
            this.taille = taille;
            Calculer();
        }
        public void Calculer()
        {
            IMC = Poids / (Taille * Taille);
        }
        public event PropertyChangedEventHandler PropertyChanged; // événement de notification
        public void OnPropertyChanged([CallerMemberName] string propertyName = null) // implémenter la méthode de notification pour l’interface utilisateur
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
