using Formulario_1.BLL;
using Formulario_1.Modelos;
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

namespace Formulario_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] categorias = { "Pulseras", "Anillos", "Cadenas", "Diademas", "Llaveros", "Sujetadores" };
        private Articulos Articulo;
        public MainWindow()
        {
            InitializeComponent();
            Articulo = new Articulos();
            this.DataContext = Articulo;
            CategoriaCombox.ItemsSource = categorias;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var registro = ArticulosBLL.Buscar(Articulo.ArticuloId);

            if(registro != null)
            {
                Articulo = registro;
                this.DataContext = Articulo;
            }
            else
            {
                MessageBox.Show("Registro no encontrado", "Error.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (ArticulosBLL.Guardar(Articulo))
            {
                MessageBox.Show("Guardado", "Aviso.", MessageBoxButton.OK, MessageBoxImage.Information);
                Articulo = new Articulos();
                this.DataContext = Articulo;
            }
            else
            {
                MessageBox.Show("No se logro guardar el registro", "Error.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            Articulo = new Articulos();
            this.DataContext = Articulo;
        }
    }
}
