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
        //Enums enums = new Enums();
        List<Animal> boardedAnimals = new List<Animal>();

        public MainWindow()
        {
            InitializeComponent();
            boardedAnimals.Add(new Dog("Mafia", Enums.sex.Male, Enums.dogBreed.Cane_Corso, false, (float)13.5));
            boardedAnimals.Add(new Dog("Sasha", Enums.sex.Spayed, Enums.dogBreed.Labrador_Retriever, true, (float)10.8));
            boardedAnimals.Add(new Dog("Ben", Enums.sex.Male, Enums.dogBreed.Great_Dane, false, (float)2.2));
            boardedAnimals.Add(new Dog("Mikey", Enums.sex.Neutered, Enums.dogBreed.Labrador_Retriever, false, (float)3.5));
            ListViewThing.ItemsSource = boardedAnimals;
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
            List<Animal> temp = new List<Animal>();
            foreach (Animal i in boardedAnimals)
            {
                if (i.getAnimalName().Length >= SearchTB_RetAni.Text.Length)
                {
                    if (i.getAnimalName().Substring(0, SearchTB_RetAni.Text.Length).ToLower() == SearchTB_RetAni.Text.ToLower())
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
