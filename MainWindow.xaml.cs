using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows;
//using JSLibrary;

namespace Book_8
{
    public partial class MainWindow : Window
    {
        string PathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\СкуфскийКликер.json";
        List<TypeDate> list = new List<TypeDate>();
        public MainWindow()
        {
            InitializeComponent();

            if (!File.Exists(PathToDesktop))
            {
                using (File.Create(PathToDesktop)) { }
            }
            Button_x2.Visibility = Visibility.Hidden;
            Button_x3.Visibility = Visibility.Hidden;
            Button_x5.Visibility = Visibility.Hidden;
            Button_x7.Visibility = Visibility.Hidden;
            Button_x10.Visibility = Visibility.Hidden;
            Button_x15.Visibility = Visibility.Hidden;
            Button_x30.Visibility = Visibility.Hidden;
        }
        private void En2(int enable)
        {
            if (enable > 40)
            {
                Button_x2.Visibility = Visibility.Visible;
            }
            if (enable > 100)
            {
                Button_x3.Visibility = Visibility.Visible;
            }
            if (enable > 300)
            {
                Button_x5.Visibility = Visibility.Visible;
            }
            if (enable > 700)
            {
                Button_x7.Visibility = Visibility.Visible;
            }
            if (enable > 1500)
            {
                Button_x10.Visibility = Visibility.Visible;
            }
            if (enable > 2000)
            {
                Button_x15.Visibility = Visibility.Visible;
            }
            if (enable > 4000)
            {
                Button_x30.Visibility = Visibility.Visible;
            }
            if (enable > 10000)
            {
                MessageBox.Show("Вы победили! Этот дурацкий кликер");
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tablo.Text = Convert.ToString(Convert.ToInt32(Tablo.Text) + 1);
            En2(int.Parse(Tablo.Text));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Tablo.Text = Convert.ToString(Convert.ToInt32(Tablo.Text) + 2);
            En2(int.Parse(Tablo.Text));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Tablo.Text = Convert.ToString(Convert.ToInt32(Tablo.Text) + 3);
            En2(int.Parse(Tablo.Text));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Tablo.Text = Convert.ToString(Convert.ToInt32(Tablo.Text) + 5);
            En2(int.Parse(Tablo.Text));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Tablo.Text = Convert.ToString(Convert.ToInt32(Tablo.Text) + 7);
            En2(int.Parse(Tablo.Text));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Tablo.Text = Convert.ToString(Convert.ToInt32(Tablo.Text) + 10);
            En2(int.Parse(Tablo.Text));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Tablo.Text = Convert.ToString(Convert.ToInt32(Tablo.Text) + 15);
            En2(int.Parse(Tablo.Text));

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Tablo.Text = Convert.ToString(Convert.ToInt32(Tablo.Text) + 30);
            En2(int.Parse(Tablo.Text));
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TypeDate typeDate = new TypeDate();
            typeDate.name = Name.Text;
            typeDate.family = Family.Text;
            typeDate.record = int.Parse(Tablo.Text);
            list.Clear();
            list.Add(typeDate);
            SerialLibrary.JS.MySerialize(list);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            list = SerialLibrary.JS.MyDeserialize<List<TypeDate>>();
            foreach (TypeDate typeDate in list)
            {
                Record.Text = Convert.ToString(typeDate.record);
                Name.Text = typeDate.name;
                Family.Text = typeDate.family;
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Tablo.Text = "0";
            Button_x2.Visibility = Visibility.Hidden;
            Button_x3.Visibility = Visibility.Hidden;
            Button_x5.Visibility = Visibility.Hidden;
            Button_x7.Visibility = Visibility.Hidden;
            Button_x10.Visibility = Visibility.Hidden;
            Button_x15.Visibility = Visibility.Hidden;
            Button_x30.Visibility = Visibility.Hidden;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            App.Theme = "en-us";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            App.Theme = "ru-ru";
        }
    }
}