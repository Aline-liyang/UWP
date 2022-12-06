using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Windows;
using Windows.UI.Popups;
using System.Threading.Tasks;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Eval3GroupeYongjiangEtLi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageVoyageur : Page
    {
        private List<Voyageur> Voyageurs = new List<Voyageur>()
         { new Voyageur("Yang","Lily","Femme","02/26/1973","YLily19730226","01/30/2023"),
           new Voyageur("Jean","Sara","Femme","10/21/1989","JSara19891021","06/30/2024"),
           new Voyageur("Parent","Leo","Homme","09/15/2009","PLeo20090915","01/30/2025"),
          };

        private int position=0;
        private bool Nouveau = true;
        private Voyageur NouveauVoyageur;
        private string sexe;
        private bool exist = false;

        public PageVoyageur()
        {
            this.InitializeComponent();
            ApplicationView appView = ApplicationView.GetForCurrentView();
            appView.Title = "Liste des voyageurs";
            DataContext = Voyageurs[position];

            if (Voyageurs[position].Sexe == "Homme")
            {
                rbthomme.IsChecked = true;
            }
            else
            {
                rbtfemme.IsChecked = true;
            }

        }

        private void tbnPremier_Click(object sender, RoutedEventArgs e)
        {
            position = 0;
            DataContext = Voyageurs[position];
            if (Voyageurs[position].Sexe == "Homme")
            {
                rbthomme.IsChecked = true;
            }
            else
            {
                rbtfemme.IsChecked = true;
            }

            string message = "Le premier enregistrement est affiché";

            // Initialize a new MessageDialog instance
            MessageDialog messageDialog = new MessageDialog(message, "Information!");

            // Display the message dialog
            messageDialog.ShowAsync();

        }

        private void tbnDernier_Click(object sender, RoutedEventArgs e)
        {
            position = Voyageurs.Count - 1;
            DataContext = Voyageurs[position];
            if (Voyageurs[position].Sexe == "Homme")
            {
                rbthomme.IsChecked = true;
            }
            else
            {
                rbtfemme.IsChecked = true;
            }

            string message = "Le dernier enregistrement est affiché";

            // Initialize a new MessageDialog instance
            MessageDialog messageDialog = new MessageDialog(message, "Information!");

            // Display the message dialog
            messageDialog.ShowAsync();


        }

        private void tbnPrecedent_Click(object sender, RoutedEventArgs e)
        {
            if (position <= 0)
            {
                position = 0;
                string message = "Le premier enregistrement est affiché";

                // Initialize a new MessageDialog instance
                MessageDialog messageDialog = new MessageDialog(message, "Information!");

                // Display the message dialog
                messageDialog.ShowAsync();

            }
            else
            {
                position = position - 1;
            }
            DataContext = Voyageurs[position];
            if (Voyageurs[position].Sexe == "Homme")
            {
                rbthomme.IsChecked = true;
            }
            else
            {
                rbtfemme.IsChecked = true;
            }



        }




        private void tbnSuivant_Click(object sender, RoutedEventArgs e)
        {
            if (position == Voyageurs.Count - 1)
            {
                position = Voyageurs.Count - 1;
                string message = "Le dernier enregistrement est affiché";

                // Initialize a new MessageDialog instance
                MessageDialog messageDialog = new MessageDialog(message, "Information!");

                // Display the message dialog
                messageDialog.ShowAsync();
            }
            else
                position += 1;
            DataContext = Voyageurs[position];

            if (Voyageurs[position].Sexe == "Homme")
            {
                rbthomme.IsChecked = true;
            }
            else
            {
                rbtfemme.IsChecked = true;
            }

        }

        private void tbnNouveau_Click(object sender, RoutedEventArgs e)
        {
            foreach (Voyageur v in Voyageurs)
            {
                if (v.NumeroPasseport.Contains(tbxNumerodepasseport.Text))

                    exist = true;
            }

            if ((Nouveau!= true) && (exist != true))
            {
                string message = "un nouvel enregistrement non ajouté";

                // Initialize a new MessageDialog instance
                MessageDialog messageDialog = new MessageDialog(message, "Information!");

                // Display the message dialog
                messageDialog.ShowAsync();

            }

            NouveauVoyageur = new Voyageur();
            DataContext = NouveauVoyageur;
            rbtfemme.IsChecked = false;
            rbthomme.IsChecked = false;
            Nouveau = false;
            exist = false;
        }

        private void tbnAjouter_Click(object sender, RoutedEventArgs e)
        {
            foreach (Voyageur v in Voyageurs)
            {
                if (v.NumeroPasseport.Contains(tbxNumerodepasseport.Text))
                {
                    string message = "l’enregistrement affiché n’est pas un nouveau ";

                    // Initialize a new MessageDialog instance
                    MessageDialog messageDialog = new MessageDialog(message, "Information!");

                    // Display the message dialog
                    messageDialog.ShowAsync();
                    Nouveau = false;
                }
                else Nouveau = true;
                
            }

            if (Nouveau)
            {
                if (rbthomme.IsChecked == true)
                {
                    sexe = "Homme";
                }
                else
                {
                    sexe = "Femme";
                }

                Voyageurs.Add(new Voyageur(tbxNom.Text, tbxPrenom.Text, sexe, tbxDatedenaissance.Text, tbxNumerodepasseport.Text, tbxDatedeance.Text));
                Nouveau = false;
                position = Voyageurs.Count - 1;
            }
           



        }

        private async void tbnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("voulez-vous supprimer ce voyageur?", "Information");

            dialog.Commands.Add(new UICommand("confirmer", cmd => { }, commandId: 0));
            dialog.Commands.Add(new UICommand("annuler", cmd => { }, commandId: 1));

            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;

           //dialog.ShowAsync();

            var result = await dialog.ShowAsync();

            if (result.Label == "confirmer")  
            {

                for (int i = Voyageurs.Count - 1; i >= 0; i--)
                {
                    if (Voyageurs[i].NumeroPasseport.Contains(tbxNumerodepasseport.Text))
                    {
                        Voyageurs.RemoveAt(i);
                        position = i - 1;
                       
                    }

                }
            }
            
        }
    }
}
