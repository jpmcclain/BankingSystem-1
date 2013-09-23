using BankingSystem.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace BankingSystem
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            if (checkSignIn())
                this.Frame.Navigate(typeof(Accounts));
            else
                wrongOutput.Text = "Username or password entered is incorrect";
        }


        private bool checkSignIn()
        {  
            bool canSignIn = false;

            if (username.Text == GlobalList._customer1.customerUsername && password.Password == GlobalList._customer1.customerPassword)
                canSignIn = true;
            else if (username.Text == GlobalList._customer2.customerUsername && password.Password == GlobalList._customer2.customerPassword)
                canSignIn = true;

            return canSignIn;       
        }

    }
}
