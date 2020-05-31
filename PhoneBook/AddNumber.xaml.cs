using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using PhoneBook.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PhoneBook
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddNumber : Page
    {
        public AddNumber()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsInputValid())
            {
                var number = new PhoneNumber(PhoneNumberTextBox.Text, OwnerTextBox.Text);
                PhoneNumberManager.Instance().AddPhoneNumber(number);
                IsValid.Text ="number succesfuly added.";
                
            }
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private bool IsInputValid()
        {
            try
            {
                int result = Int32.Parse(PhoneNumberTextBox.Text);
                return true;
            }
            catch (FormatException)
            {
                IsValid.Text = "Invalid Phone Number";
                return false;
            }
        }
    }
}
