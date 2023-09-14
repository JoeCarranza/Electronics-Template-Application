using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            TemplateSection.Text = "\n------------------------------------------------------------------------------------\r\n\r\n>Serial Number: \r\n\r\n>Printer Model:  \r\n\r\n>Problem Description: \r\n\r\n>DCC %: \r\n\r\n>Fleet Ops: \r\n\r\n>EWS Access: \r\n\r\n>Previous Cases: \r\n\r\n>Action Plan: Sending tech to diagnose, get internal pages, replace the recommended part as needed. Verify printer functionality before leaving the site. If further assistance is needed, please contact Tech Assist\r\n\r\n>Part recommended : \r\n\r\n>TL Consulted: \r\n\r\n"
                + Environment.NewLine;
        }

        private void LACTemplate(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "\n------------------------------------------------------------------------------------\r\n\r\n>Numero de serie: \r\n\r\n>Modelo:  \r\n\r\n>Descripcion del problema: \r\n\r\n>DCC %: \r\n\r\n>Fleet Ops: \r\n\r\n>Acceso EWS: \r\n\r\n>Casos previos: \r\n\r\n>Plan de acción: Se envía técnico al sitio a diagnoticar y a remplazar las partes recomendadas, si el problema persiste contactar a TA.\r\n\r\n>Parte recomendada : \r\n\r\n>Consulta TL: \r\n\r\n"
               + Environment.NewLine;
        }

        private void BupaTemplate(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "\n------------------------------------------------------------------------------------\r\n\r\nEste es un cliente CONTRACTUAL dMPS por favor proceda con el diagnóstico y el despacho de la solución.\r\n\r\n" + Environment.NewLine;
        }

        private void DuplicateTemplate(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "\n------------------------------------------------------------------------------------\r\n\r\nThis is a duplicate case. \r\nThe error is worked in this case number: \r\n\r\n" + Environment.NewLine;
        }

        private void EventReady(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TemplateSection.Text))
            {
                Clipboard.SetText(TemplateSection.Text);
                MessageBoxResult result = MessageBox.Show("Copy Note", "Copy!", MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Empty Note, please review", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void CopyTlConsulted(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxTlConsulted.Text))
            {
                Clipboard.SetText(txtBoxTlConsulted.Text);
                MessageBoxResult result = MessageBox.Show("TL Consulted Title Copy", "Copy!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Empty title, please review", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void CopyWOTitle(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxWOTitle.Text))
            {
                Clipboard.SetText(txtBoxWOTitle.Text);
                MessageBoxResult result = MessageBox.Show("WO Title Copy", "Copy!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Empty title, please review", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ClearTemplateSection(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = string.Empty;
            txtBoxTlConsulted.Text = "#Case / #PIN / DBD";
            txtBoxWOTitle.Text = string.Empty;
        }
    }
}
