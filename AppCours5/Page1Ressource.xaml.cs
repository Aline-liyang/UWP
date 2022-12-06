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

namespace AppCours5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1Ressource : Page
    {
        public Page1Ressource()
        {
            this.InitializeComponent();
        }

        private void BtnCalculer_Click(object sender, RoutedEventArgs e)
        {
            float poids = float.Parse(tbxPoids.Text);
            float taille = float.Parse(tbxTaille.Text);
            float imc = poids / (taille * taille);
            tbxIMC.Text = String.Format("{0:N}", imc);
        }


    }
}
