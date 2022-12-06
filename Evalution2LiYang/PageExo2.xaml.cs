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

namespace Evalution2LiYang
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PageExo2 : Page
    {
        private int donSelectionne;
        private int dons;
        public PageExo2()
        {
            this.InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            donSelectionne = 10;
            tbxDon.Text = "10";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            donSelectionne = 20;
            tbxDon.Text = "20";
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            donSelectionne = 30;
            tbxDon.Text = "30";
        }

       

        private void tbxDon_TextChanged(object sender, TextChangedEventArgs e)
        {
            donSelectionne = int.Parse(tbxDon.Text);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            donSelectionne = int.Parse(tbxDon.Text);
            dons = donSelectionne + dons;
            tbxTotalDons.Text = dons.ToString();
        }
    }
}

