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

namespace CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Creacion de variables
            Button boton;
            Viewbox vb;
            TextBlock tb;
            int contadorTag = 1;
            for (int contadorFila = 2; contadorFila <= 4; contadorFila++)
            {
                for (int contadorColumna = 0; contadorColumna < 3; contadorColumna++)
                {
                    //Definimos variables
                    boton = new Button();
                    vb = new Viewbox();
                    tb = new TextBlock();


                    //Creamos el orden de hijos/padres
                    GridVentana.Children.Add(boton);
                    boton.Content = vb;
                    vb.Child = tb;



                    //Agregamos propiedades
                    tb.Text = contadorTag.ToString();
                    boton.Tag = contadorTag;
                    Grid.SetColumn(boton, contadorColumna);
                    Grid.SetRow(boton, contadorFila);
                    boton.Margin = new Thickness(2);
                    contadorTag++;
                    boton.Click += Button_Click;
                }
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button boton = sender as Button;
            TextBlockNumeros.Text += boton.Tag;
        }
    }
}
