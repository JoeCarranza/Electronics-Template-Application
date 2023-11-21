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
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;

namespace ElectronicsTemplateApp.View
{
    /// <summary>
    /// Interaction logic for Electronics_Template_Application.xaml
    /// </summary>
    /// 
    
    public partial class Electronics_Template_Application : Window
    {

        List<USState> usStates = new List<USState>

{
    new USState { Name = "Alabama", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Alaska", TimeZoneId = "Alaskan Standard Time" },
    new USState { Name = "Arizona", TimeZoneId = "US Mountain Standard Time" },
    new USState { Name = "Arkansas", TimeZoneId = "Central Standard Time" },
    new USState { Name = "California", TimeZoneId = "Pacific Standard Time" },
    new USState { Name = "Colorado", TimeZoneId = "Mountain Standard Time" },
    new USState { Name = "Connecticut", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Delaware", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Florida", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Georgia", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Hawaii", TimeZoneId = "Hawaiian Standard Time" },
    new USState { Name = "Idaho", TimeZoneId = "Mountain Standard Time" },
    new USState { Name = "Illinois", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Indiana", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Iowa", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Kansas", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Kentucky", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Louisiana", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Maine", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Maryland", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Massachusetts", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Michigan", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Minnesota", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Mississippi", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Missouri", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Montana", TimeZoneId = "Mountain Standard Time" },
    new USState { Name = "Nebraska", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Nevada", TimeZoneId = "Pacific Standard Time" },
    new USState { Name = "New Hampshire", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "New Jersey", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "New Mexico", TimeZoneId = "Mountain Standard Time" },
    new USState { Name = "New York", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "North Carolina", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "North Dakota", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Ohio", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Oklahoma", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Oregon", TimeZoneId = "Pacific Standard Time" },
    new USState { Name = "Pennsylvania", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Rhode Island", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "South Carolina", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "South Dakota", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Tennessee", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Texas", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Utah", TimeZoneId = "Mountain Standard Time" },
    new USState { Name = "Vermont", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Virginia", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Washington state", TimeZoneId = "Pacific Standard Time" },
    new USState { Name = "West Virginia", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Wisconsin", TimeZoneId = "Central Standard Time" },
    new USState { Name = "Wyoming", TimeZoneId = "Mountain Standard Time" },
    new USState { Name = "Washington DC", TimeZoneId = "Eastern Standard Time" },
    new USState { Name = "Santiago, Chile", TimeZoneId = "Pacific SA Standard Time"},
};
        private List<USState> filteredStates;

        public Electronics_Template_Application()
        {

            InitializeComponent();
            DataContext = this;

            // Asignar la lista de estados al ComboBox
            StateComboBox.ItemsSource = usStates;

            // Maneja el evento de selección del ComboBox
            StateComboBox.SelectionChanged += (sender, e) => UpdateTime();

            // Inicializa la lista filtrada con la lista completa al principio
            filteredStates = usStates;

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
            TemplateSection.Text = "\n------------------------------------------------------------------------------------\r\n\r\n>Serial Number: \r\n\r\n>Printer Model:  \r\n\r\n>Problem Description: \r\n\r\n>DCC %: \r\n\r\n>Fleet Ops: \r\n\r\n>EWS Access: \r\n\r\n>Previous Cases: \r\n\r\n>Troubleshooting Steps: \r\n\r\n>Action Plan: \r\n\r\n>Part recommended : \r\n\r\n>TL Consulted: \r\n"
                + Environment.NewLine;
            TxtLastAction.Text = "Selected USA Template";
        }

        private void LACTemplate(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "\n------------------------------------------------------------------------------------\r\n\r\n>Numero de serie: \r\n\r\n>Modelo:  \r\n\r\n>Descripcion del problema: \r\n\r\n>DCC %: \r\n\r\n>Fleet Ops: \r\n\r\n>Acceso EWS: \r\n\r\n>Casos previos: \r\n\r\n>Diagnóstico Realizado: \r\n\r\n>Plan de acción: \r\n\r\n>Parte recomendada : \r\n\r\n>Consulta TL: \r\n\r\n>Asignar a canal: \r\n"
               + Environment.NewLine;
            TxtLastAction.Text = "Selected LAC Template";
        }

        private void BupaTemplate(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "\n------------------------------------------------------------------------------------\r\n\r\nEste es un cliente CONTRACTUAL dMPS por favor proceda con el diagnóstico y el despacho de la solución.\r\n" + Environment.NewLine;
            TxtLastAction.Text = "Selected BUPA Template";
            OthersToggleButton.IsChecked = false;
        }

        private void DuplicateTemplate(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "\n------------------------------------------------------------------------------------\r\n\r\nThis is a duplicate case. \r\nThe issue is worked under this case number: \r\n" + Environment.NewLine;
            TxtLastAction.Text = "Selected Duplicate Template";
            OthersToggleButton.IsChecked = false;
        }

        private void EventCopyTemplateSection(object sender, RoutedEventArgs e)
        {
            string texto = "1&#x0A;------------------------------------------------------------------------------------";
            if (!string.IsNullOrWhiteSpace(TemplateSection.Text) && !string.Equals(TemplateSection.Text, texto))
            {
                Clipboard.SetText(TemplateSection.Text);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Empty title, please review", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            TxtLastAction.Text = "Copy Template Section";
        }

        private void CopyTlConsulted(object sender, RoutedEventArgs e)

        {
            TxtLastAction.Text = "Copy TL Consulted Title";
            string texto = "#Case / #PIN / DBD-NonDBD";

            if (!string.IsNullOrWhiteSpace(txtBoxTlConsulted.Text) && !string.Equals(txtBoxTlConsulted.Text, texto))
            {
                Clipboard.SetText(txtBoxTlConsulted.Text);
                
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Empty title, please review", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void CopyWOTitle(object sender, RoutedEventArgs e)
        {
            TxtLastAction.Text = "Copy WO Title";
            string texto = "ResponseTime / ISSUE";
            if (!string.IsNullOrWhiteSpace(txtBoxWOTitle.Text) && !string.Equals(txtBoxWOTitle.Text, texto))
            {
                Clipboard.SetText(txtBoxWOTitle.Text);
                
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Empty title, please review", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }

        private void ClearTemplateSection(object sender, RoutedEventArgs e)
        {
            TxtLastAction.Text = "Clear all sections";
            TemplateSection.Text = "\n------------------------------------------------------------------------------------";
            txtBoxTlConsulted.Text = "#Case / #PIN / DBD-NonDBD";
            txtBoxWOTitle.Text = "ResponseTime / ISSUE";
        }

        private void ClearTlConsulted(object sender, RoutedEventArgs e)
        {
            TxtLastAction.Text = "Clear TL Consulted Section";
            txtBoxTlConsulted.Text = "#Case / #PIN / DBD-NonDBD";
        }

        private void ClearWOTitle(object sender, RoutedEventArgs e)
        {
            txtBoxWOTitle.Text = "ResponseTime / ISSUE";
            TxtLastAction.Text = "Clear Wo Tittle Section";
        }

        private void ClearTemplateSection2(object sender, RoutedEventArgs e)
        {
            TxtLastAction.Text = "Clear Template Section";
            TemplateSection.Text = "\n------------------------------------------------------------------------------------";
        }

        private void OneOff(object sender, RoutedEventArgs e)
        {
            PartSurferView.Visibility = Visibility.Collapsed;
            OneOffPanel.Visibility = Visibility.Visible;
            OneOffBorder.Visibility = Visibility.Visible;
            OneOffView.Visibility = Visibility.Visible;
        }

        private void HideOneOff(object sender, RoutedEventArgs e)
        {
            OneOffPanel.Visibility = Visibility.Collapsed;
            OneOffBorder.Visibility = Visibility.Collapsed;
        }

        private void BackOneOff(object sender, RoutedEventArgs e)
            //Evento para ir atras en el WebView del OneOff
        {
            if(OneOffView.Visibility == Visibility.Visible) { 
                 if(myWebView.CanGoBack)
                 {
                      myWebView.GoBack();
                 } 
            }
            else if (PartSurferView.Visibility == Visibility.Visible)
            {
                if (myWebView2.CanGoBack)
                {
                    myWebView2.GoBack();
                }
            }
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
            //Evento para hacia adelante en el WebView del OneOff
        {
            if (OneOffView.Visibility == Visibility.Visible)
            {
                if (myWebView.CanGoForward)
                {
                    myWebView.GoForward();
                }
            }
            else if (PartSurferView.Visibility == Visibility.Visible)
            {
                if (myWebView2.CanGoForward)
                {
                    myWebView2.GoForward();
                }
            }
        }

        private void ReloadButton_Click(object sender, RoutedEventArgs e)
            //Evento para recargar la pagina web de OneOff
        {
            if (OneOffView.Visibility == Visibility.Visible)
            {
                myWebView.Reload();
            }
            else if (PartSurferView.Visibility == Visibility.Visible)
            {
                myWebView2.Reload();
            }
        }

        private void IncreaseLetter_Click(object sender, RoutedEventArgs e)
        {
            double size = TemplateSection.FontSize;

            size += 1;

            TemplateSection.FontSize = size;
        }

        private void DecreaseLetter_Click(object sender, RoutedEventArgs e)
        {
            double size = TemplateSection.FontSize;

            size -= 1;

            TemplateSection.FontSize = size;
        }

        private void EOSL_Click(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "\n------------------------------------------------------------------------------------\r\n\r\nHello CM,\r\n\r\nToday we received a request for a EOSL device, please provide guidance on the following steps:\r\n\r\nCDAX case number:\r\n\r\nSerial number:\r\n\r\nCustomer information:\r\n\r\nIssue description:\r\n\r\nWe will awaiting for your response.\r\n\r\nRegards.\r\n" + Environment.NewLine;
            TxtLastAction.Text = "Selected EOSL Template";
            OthersToggleButton.IsChecked = false;
        }

        private void EE_Click(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "\n------------------------------------------------------------------------------------\r\n\r\nGood Day MPS-R,\r\n\r\nCase number:\r\n\r\nSerial number:\r\n\r\nAfter performing TS, it was determined this unit cannot be fixed and it applies for EE.\r\n\r\nPlease proceed.\r\n\r\nIf there is anything else just let me know.\r\n" + Environment.NewLine;
            TxtLastAction.Text = "Selected EE Template";
            OthersToggleButton.IsChecked = false;
        }

        private void FMEP_Click(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "\n------------------------------------------------------------------------------------\r\n\r\nHello [NAME],\r\n\r\nI hope you’re doing fine,\r\n\r\nHP Remote Engineers assigned to your account have identified a future device failure, in order to avoid any device downtime, we are sending an onsite engineer to verify and change a part. \r\n\r\nThe intention of this email is to confirm the physical address of the printer:\r\n\r\nSerial number:\r\n\r\nModel:\r\n\r\nSo, the engineer can reach it and provide this proactive service:\r\n\r\n[DIRECCION COMPLETA DE DCC]\r\n\r\nPlease confirm the address is correct and whether you are the correct site contact, or you want us to address someone else within your company.\r\n\r\nNote this is a proactive service, your device may not be presenting any problem yet.\r\n" + Environment.NewLine;
            TxtLastAction.Text = "Selected FMEP Template";
            OthersToggleButton.IsChecked = false;
        }

        private void TonerApproval_Click(object sender, RoutedEventArgs e)
        {
            TemplateSection.Text = "\n------------------------------------------------------------------------------------\r\n\r\nGood Day [CSM],\r\n\r\nAccording to One-Off we need your authorization before proceeding. Please review the information below and reply to this email with a confirmation:\r\n\r\nCompany: \r\n\r\nSerial Number: \r\n\r\nPrinter location: \r\n\r\nCustomer name\r\n\r\nPhone: \r\n\r\nEmail: \r\n\r\nCustomer request: [Example:1 black toner]\r\n\r\nPlease let me know how to proceed.\r\n" + Environment.NewLine;
            TxtLastAction.Text = "Selected Toner Approval Template";
            OthersToggleButton.IsChecked = false;
        }

        private void EWS_opc1(object sender, RoutedEventArgs e)
        {
            string opc = "Operation Not available";
            Clipboard.SetText(opc);
            TxtLastAction.Text = "Selected Operation Not available";
            EWSToggleButton.IsChecked = false;
        }

        private void EWS_opc2(object sender, RoutedEventArgs e)
        {
            string opc = "Operation available - Connection Failed";
            Clipboard.SetText(opc);
            TxtLastAction.Text = "Selected Connection Failed";
            EWSToggleButton.IsChecked = false;
        }

        private void EWS_opc3(object sender, RoutedEventArgs e)
        {
            string opc = "Operation available - Sign In Required";
            Clipboard.SetText(opc);
            TxtLastAction.Text = "Selected Sign In Required";
            EWSToggleButton.IsChecked = false;
        }

        private void FO_Click1(object sender, RoutedEventArgs e)
        {
            string opc = "No Device Found";
            Clipboard.SetText(opc);
            TxtLastAction.Text = "Selected No Device Found";
            FOToggleButton.IsChecked = false;
        }

        private void FO_Click2(object sender, RoutedEventArgs e)
        {
            string opc = "No Data Found";
            Clipboard.SetText(opc);
            TxtLastAction.Text = "Selected No Data Found";
            FOToggleButton.IsChecked = false;
        }

        private void FO_Click3(object sender, RoutedEventArgs e)
        {
            string opc = "No Connector Associated";
            Clipboard.SetText(opc);
            TxtLastAction.Text = "Selected No Connector Associated";
            FOToggleButton.IsChecked = false;
        }

        private void FO_Click4(object sender, RoutedEventArgs e)
        {
            string opc = "Events outdated";
            Clipboard.SetText(opc);
            TxtLastAction.Text = "Selected Events outdated";
            FOToggleButton.IsChecked = false;
        }

        private void PartSurfer_Click(object sender, RoutedEventArgs e)
        {
            OneOffView.Visibility = Visibility.Collapsed;
            OneOffPanel.Visibility = Visibility.Visible;
            OneOffBorder.Visibility = Visibility.Visible;
            PartSurferView.Visibility = Visibility.Visible;
        }

        private void TimeZone_Click(object sender, RoutedEventArgs e)
        {
            OneOffView.Visibility = Visibility.Collapsed;
            OneOffPanel.Visibility = Visibility.Visible;
            OneOffBorder.Visibility = Visibility.Visible;
            PartSurferView.Visibility = Visibility.Collapsed;
            TimeZoneView.Visibility = Visibility.Visible;
        }
        private void UpdateTime()
        {
            // Obtener el objeto USState seleccionado desde el ComboBox
            USState selectedState = (USState)StateComboBox.SelectedItem;

            if (selectedState != null)
            {
                // Obtener la zona horaria seleccionada desde el objeto USState
                string timeZoneId = selectedState.TimeZoneId;

                // Calcular la hora actual en la zona horaria seleccionada
                TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
                DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, timeZone);


            //Condicion si es Viernes y se pasa de las 5:00 PM (Lo tira al lunes a partir de las 8:00 AM)
            if (currentTime.DayOfWeek == DayOfWeek.Friday && currentTime.Hour >= 17 )
            {
                    // Sumar las 4 horas desde el día siguiente a las 8:00 AM
                    DateTime nextDay = currentTime.Date.AddDays(1); // Obtener el día siguiente
                    DateTime updatedTime = new DateTime(nextDay.Year, nextDay.Month, nextDay.Day, 8, 0, 0);

                    // Sumar 4 horas y los minutos actuales
                    updatedTime = updatedTime.AddHours(52);

                    //Mostrar la fecha y hora de la hora actual
                    ActualTimeDisplay.Text = $"Current time in {selectedState.Name}: {currentTime:F}";
                    // Mostrar el SLA definido con las 4 horas sumadas.
                    TimeDisplay.Text = $"Estimated SLA in {selectedState.Name}: {updatedTime:F}";

                }


            // Verificar si la hora actual supera las 5:00 PM
            else if (currentTime.Hour >= 17)
            {
                // Sumar las 4 horas desde el día siguiente a las 8:00 AM
                DateTime nextDay = currentTime.Date.AddDays(1); // Obtener el día siguiente
                DateTime updatedTime = new DateTime(nextDay.Year, nextDay.Month, nextDay.Day, 8, 0, 0);

                // Sumar 4 horas y los minutos actuales
                updatedTime = updatedTime.AddHours(4);

                //Mostrar la fecha y hora de la hora actual
                ActualTimeDisplay.Text = $"Current time in {selectedState.Name}: {currentTime:F}";
                // Mostrar el SLA definido con las 4 horas sumadas.
                TimeDisplay.Text = $"Estimated SLA in {selectedState.Name}: {updatedTime:F}";
            }


                // Verificar si la hora actual es menor a las 8:00 am
             else if (currentTime.Hour < 8)
             {
                    // Sumar las 4 horas a partir de las 8:00 am
                    DateTime updatedTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 8, 0, 0);
                    updatedTime = updatedTime.AddHours(4);

                    //Mostrar la fecha y hora de la hora actual
                    ActualTimeDisplay.Text = $"Current time in {selectedState.Name}: {currentTime:F}";
                    // Mostrar el SLA definido con las 4 horas sumadas.
                    TimeDisplay.Text = $"Estimated SLA in {selectedState.Name}: {updatedTime:F}";
                }


             else
              {
                    // Sumar 4 horas al resultado
                    DateTime updatedTime = currentTime.AddHours(4);

                    // Verificar si el resultado supera las 5:00 PM
                    if (updatedTime.Hour >= 17 && updatedTime.DayOfWeek != DayOfWeek.Friday)
                    {
                        // Sumar las horas restantes al siguiente día a partir de las 8:00 AM
                        DateTime nextDay = updatedTime.Date.AddDays(1);
                        DateTime adjustedTime = new DateTime(nextDay.Year, nextDay.Month, nextDay.Day, 8, 0, 0);

                        // Sumar las horas restantes y los minutos actuales
                        adjustedTime = adjustedTime.AddHours(updatedTime.Hour - 17).AddMinutes(updatedTime.Minute);

                        //Mostrar la fecha y hora de la hora actual
                        ActualTimeDisplay.Text = $"Current time in {selectedState.Name}: {currentTime:F}";
                        // Mostrar el SLA definido con las 4 horas sumadas.
                        TimeDisplay.Text = $"Estimated SLA in {selectedState.Name}: {adjustedTime:F}";
                    }

                    //Condicion si es Viernes y la suma de las 4 Horas superan las 5:00 PM (Lo tiran a partir de las 8:00 AM del lunes)
                    else if (updatedTime.DayOfWeek == DayOfWeek.Friday && updatedTime.Hour >= 17)
                    {
                        // Sumar las horas restantes al siguiente día a partir de las 8:00 AM
                        DateTime nextDay = updatedTime.Date.AddDays(3);
                        DateTime adjustedTime = new DateTime(nextDay.Year, nextDay.Month, nextDay.Day, 8, 0, 0);



                        // Sumar las horas restantes y los minutos actuales
                        adjustedTime = adjustedTime.AddHours(updatedTime.Hour - 17).AddMinutes(updatedTime.Minute);

                        //Mostrar la fecha y hora de la hora actual
                        ActualTimeDisplay.Text = $"Current time in {selectedState.Name}: {currentTime:F}";
                        // Mostrar el SLA definido con las 4 horas sumadas.
                        TimeDisplay.Text = $"Estimated SLA in {selectedState.Name}: {adjustedTime:F}";
                    }
                    else     
                    {
                        //Mostrar la fecha y hora de la hora actual
                        ActualTimeDisplay.Text = $"Current time in {selectedState.Name}: {currentTime:F}";
                        // Mostrar el SLA definido con las 4 horas sumadas.
                        TimeDisplay.Text = $"Estimated SLA in {selectedState.Name}: {updatedTime:F}";
                    }
                }
           }
        }

        private void StateComboBox_TextChanged(object sender, RoutedEventArgs e)
        {
            string searchText = StateComboBox.Text.ToLower();

            // Filtra los estados basándote en el texto ingresado
            List<USState> filteredStates = usStates
                .Where(state => state.Name.ToLower().Contains(searchText))
                .ToList();

            // Asigna la lista filtrada al ComboBox
            StateComboBox.ItemsSource = filteredStates;
        }
    }
}

