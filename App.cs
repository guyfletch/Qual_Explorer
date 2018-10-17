using Xamarin.Forms;

namespace Qual_Explorer
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new QualPage(DataStore.Instance));
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

