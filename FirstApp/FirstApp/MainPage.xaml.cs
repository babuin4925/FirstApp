using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        private StackLayout layout;
        public MainPage()
        {
            InitializeComponent();
        }

        public int Counter{ get; private set; }

        protected override void OnAppearing()
        {
            Counter = 0; //default counter value
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Counter++;
            CounterLabel.Text = $"You clicked {Counter} times";
        }
    }
}
