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

        public Customer customer1 { get; set; }
        public Customer customer2 { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            CreateCustomers();
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

            if (username.Text == customer1.customerUsername && password.Password == customer1.customerPassword)
                canSignIn = true;
            else if (username.Text == customer2.customerUsername && password.Password == customer2.customerPassword)
                canSignIn = true;

            return canSignIn;
                
        }


        private void CreateCustomers()
        {
            customer1 = new Customer("Sam", "moreMoney", "12345", "whatever@ttu.edu", 436764, 792304, false, 2367.47, 1155.82);
            customer2 = new Customer("Bill", "lessMoney", "54321", "anyways@ttu.edu", 783496, 425395, false, 0.47, 268.82);
        }
    }
}
