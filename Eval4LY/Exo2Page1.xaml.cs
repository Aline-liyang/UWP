using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Eval4LY
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Exo2Page1 : Page
    {
        private List<Centre> centres = new List<Centre>();


        private int total = 0;
        private string nom;
        private string categorie;
        private string image1;
        private string image2;
        private string image3;
        private int position = 0;





        public Exo2Page1()
        {
            this.InitializeComponent();

            //Centre centre1 = new Centre("Centre1", "C1", "/Assets/C1Image1.jpg", "/Assets/C1Image2.jpg", "/Assets/C1Image3.jpg");
            //Centre centre2 = new Centre("Centre1", "C2", "/Assets/C2Image1.jpg", "/Assets/C2Image2.jpg", "/Assets/C3Image3.jpg");
            //Centre centre3 = new Centre("Centre1", "C3", "/Assets/C3Image1.jpg", "/Assets/C2Image2.jpg", "/Assets/C3Image3.jpg");

            //centres.Add(centre1);
            //centres.Add(centre2);
            //centres.Add(centre3);
            //DataContext = centres[position];
        }
        //private void comboxCategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    categorie = e.AddedItems[0].ToString();
        //}

        private void btnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            total = total + 1;
            nom = tbxNom.Text;
            categorie = comboxCategorie.SelectedValue.ToString();
            image1 = tbxImage1.Text;
            image2 = tbxImage2.Text;
            image3 = tbxImage3.Text;

            centres.Add(new Centre(nom, categorie, image1, image2, image3));

            tbxTotal.Text = "Total Centres:  " + total.ToString();
            tbxAffichier.Text = total.ToString();
        }

        private void btnAffichier_Click(object sender, RoutedEventArgs e)
        {
            position = int.Parse(tbxAffichier.Text);
           
            if (position > centres.Count)
            {
                tbxNom.Text = "";
                comboxCategorie.SelectedValue = "Centre de Remise en Forme";
                tbxImage1.Text = "";
                tbxImage2.Text = "";
                tbxImage3.Text = "";

            }
            else
            {
                tbxNom.Text = centres[position-1].Nom;
                comboxCategorie.SelectedValue = centres[position-1].Categorie;
                tbxImage1.Text = centres[position - 1].Image1;
                tbxImage2.Text = centres[position - 1].Image2;
                tbxImage3.Text = centres[position - 1].Image3;


            }

        }

       
    }
}
