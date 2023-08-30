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

        private void USATemplate(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "-------------------------------------------------------------------------------------\r\n\r\nSerial Number: \r\n\r\nPrinter Model:  \r\n\r\nProblem Description: \r\n\r\nDCC %: \r\n\r\nFleet Ops: \r\n\r\nEWS Access: \r\n\r\nPrevious Cases: \r\n\r\nAction Plan: Sending tech to diagnose, get internal pages, replace the recommended part as needed. Verfify printer functionality before leaving the site. If further assistance is needed, please contact Tech Assist\r\n\r\nPart recommended : \r\n\r\nTL Consulted: \r\n\r\n-------------------------------------------------------------------------------------\r\n"
                + Environment.NewLine;
        }

        private void LACTemplate(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "-------------------------------------------------------------------------------------\r\n\r\nNumero de serie: \r\n\r\nModelo:  \r\n\r\nDescripcion del problema: \r\n\r\nDCC %: \r\n\r\nFleet Ops: \r\n\r\nAcceso EWS: \r\n\r\nCasos previos: \r\n\r\nPlan de acción: Se envía técnico al sitio a diagnoticar y a remplazar las partes recomendadas, si el problema persiste contactar a TA.\r\n\r\nParte recomendada : \r\n\r\nConsulta TL: \r\n\r\n-------------------------------------------------------------------------------------\r\n"
               + Environment.NewLine;
        }

        private void BupaTemplate(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "-------------------------------------------------------------------------------------\r\n\r\nEste es un cliente CONTRACTUAL dMPS por favor proceda con el diagnóstico y el despacho de la solución.\r\n\r\n-------------------------------------------------------------------------------------\r\n" + Environment.NewLine;
        }

        private void DuplicateTemplate(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "-------------------------------------------------------------------------------------\r\n\r\nThis is a duplicate case. \r\nThe error is worked in this case number: \r\n\r\n-------------------------------------------------------------------------------------\r\n" + Environment.NewLine;
        }
    }
}
