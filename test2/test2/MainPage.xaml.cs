using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test2.ClassModel;
using Xamarin.Forms;

namespace test2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GlobalClass.accounts.Add(new Account("loginesa", "123", new UserClass("4TP", @"https://zstio.edu.pl/plan/u/podzgodz/plan.php?kl=123F69DA832927A6")));
            GlobalClass.accounts.Add(new Account("loginesa2", "1234", new UserClass("2TP", @"https://zstio.edu.pl/plan/u/podzgodz/plan.php?kl=3A4D87253A6AAA3F")));
            GlobalClass.accounts.Add(new Account("loginesa3", "12345", new UserClass("5TP", @"https://zstio.edu.pl/plan/u/podzgodz/plan.php?kl=2FE6DBDB64885790")));
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            foreach (var account in GlobalClass.accounts) 
            {
               
            }
        }
    }
}
