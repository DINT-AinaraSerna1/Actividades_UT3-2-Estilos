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

namespace Tema3_CalculadoraDinamica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button boton1 = new ();
            TextBlock textBlock1 = new ();
            Viewbox viewbox1 = new ();
                       

            textBlock1.Text = "1";
            viewbox1.Child = textBlock1;
            boton1.Content = viewbox1;
            Secundario.Children.Add(boton1);
            Grid.SetColumn (boton1, 0);
            Grid.SetRow (boton1, 0);
           
            boton1.Click += Button_Click;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            cuadroTexto.Text += button.Tag.ToString();
        }
    }
}
