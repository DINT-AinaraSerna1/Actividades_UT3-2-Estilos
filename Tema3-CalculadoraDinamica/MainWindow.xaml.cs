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

            List<TextBlock> textBlocks = new List<TextBlock>();
            TextBlock textBlock;
            List<Viewbox> viewboxes = new ();
            Viewbox viewbox;

            List<Button> buttons = new List<Button>();
            Button boton;
            int tag = 1;
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    boton = new();
                    viewbox = new();
                    textBlock = new();

                    textBlock.Text = tag.ToString();
                    viewbox.Child = textBlock;
                    boton.Content = viewbox;
                    boton.Tag = tag.ToString();

                    Secundario.Children.Add(boton);
                    Grid.SetColumn(boton, j);
                    Grid.SetRow(boton, i);

                    buttons.Add(boton);
                    viewboxes.Add(viewbox);
                    textBlocks.Add(textBlock);
                    tag++;
                }
            }
            boton = new();
            viewbox = new();
            textBlock = new();
            textBlock.Text = "0";
            viewbox.Child = textBlock;
            boton.Content = viewbox;
            boton.Tag = textBlock.Text;
            Principal.Children.Add(boton);
            Grid.SetRow(boton, 2);
            buttons.Add(boton);
            viewboxes.Add(viewbox);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            cuadroTexto.Text += button.Tag.ToString();
        }
    }
}
