using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KennelSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> list = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            list.Add("Evan");
            list.Add("Ethan");
            list.Add("Joseph");
            list.Add("Nathan");
            list.Add("Nut");
            ListViewThing.ItemsSource = list;
        }

        private void LogoutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Press");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.ReturningCustomerGrid.Visibility == Visibility.Hidden)
            {
                this.ReturningCustomerGrid.Visibility = Visibility.Visible;
            }
            else
            {
                this.ReturningCustomerGrid.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void AutoCompleteSearch(object sender, TextChangedEventArgs e)
        {
            List<string> temp = new List<string>();
            foreach (string i in list)
            {
                if (i.Length >= SearchTB_RetAni.Text.Length)
                {
                    if (i.Substring(0, SearchTB_RetAni.Text.Length).ToLower() == SearchTB_RetAni.Text.ToLower())
                    {
                        temp.Add(i);
                    }
                }
            }
            ListViewThing.ItemsSource = temp;
        }

        private void ListViewThing_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(ListViewThing.SelectedItem.ToString());
        }

        private void BoardReleaseSearchTB_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= BoardReleaseSearchTB_GotFocus;
        }

        private void BoardReleaseSearchTB_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = "Search by last name...";
            tb.GotFocus += BoardReleaseSearchTB_GotFocus;
        }
    }
}
