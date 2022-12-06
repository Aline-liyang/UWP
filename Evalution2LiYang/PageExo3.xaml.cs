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
    public sealed partial class PageExo3 : Page
    {
        private int don;
        private int dons = 0;
        private string name;
        private List<listDon> Donlist = new List<listDon>();
        private int position = 0;


        public PageExo3()
        {
            this.InitializeComponent();
            //changement de titre

        }

        private void tbxDon_TextChanged(object sender, TextChangedEventArgs e)
        {
                
            don = int.Parse(tbxDon.Text);
          
            
        }

        private void tbxDonateur_TextChanged(object sender, TextChangedEventArgs e)
        {
            name = tbxDonateur.Text;
        }



        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            dons = dons + don;
            tbxTotalDons.Text = dons.ToString();

            Donlist.Add(new listDon(name, don));

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Donlist.Count == 0)
            {
                tbxDonateur.Text = " ";
                tbxDon.Text = " ";
            }
            else
            {

                if (position == Donlist.Count - 1)
                    position = 0;
                else
                    position += 1;

                tbxDonateur.Text = Donlist[position].Name;
                tbxDon.Text = Donlist[position].Don.ToString();
            }
        }
    }
}
