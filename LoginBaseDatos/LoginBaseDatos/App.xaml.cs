﻿using Xamarin.Forms;

namespace LoginBaseDatos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RegistrationPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
