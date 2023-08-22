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
using System.Windows.Shapes;

namespace ElectronicsTemplateApp.View
{
    /// <summary>
    /// Interaction logic for Electronics_Template_Application.xaml
    /// </summary>
    public partial class Electronics_Template_Application : Window
    {
        public Electronics_Template_Application()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove(); //Esto es para poder mover la app dentro del escritorio, ya que al quitarle la propiedad del titulo se quita.
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            //Evento de minimizar la app

            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
