using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SfListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            //OnTapGestureRecognizerTappedOnce(sender, args);
            this.Navigation.PushAsync(new Page1());


        }
        void OnTapGestureRecognizerTappedOnce(object sender, EventArgs args)
        {

            App.Current.MainPage.DisplayAlert("Login Success", "", "Ok");
            //System.Diagnostics.Debug.WriteLine("<||> NumberOfTapsRequired 1");

        }
    }
}
