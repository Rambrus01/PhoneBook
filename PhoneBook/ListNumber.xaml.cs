using System;
using System.Collections.Generic;
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
    public sealed partial class ListNumber : Page
    {
        public ListNumber()
        {
            this.InitializeComponent();

            if (!isPhoneNumberManagerEmpty())
            {
                NumberTextBlock.Text = PhoneNumberManager.Instance().getAllNumber().ElementAt(0).number;
                OwnerTextBlock.Text = PhoneNumberManager.Instance().getAllNumber().ElementAt(0).owner;
            }
        }

        private bool isPhoneNumberManagerEmpty()
        {
            return PhoneNumberManager.Instance().getAllNumber().Count() == 0;
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}
