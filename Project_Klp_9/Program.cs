using Project_Klp_9.Models;
using Project_Klp_9.Presenter;

namespace Project_Klp_9
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Jalankan form login terlebih dahulu
            IView loginView = new LoginForm();
            UserRepository userRepository = new UserRepository();
            new LoginPresenters(loginView, userRepository);

            Application.Run((Form)loginView);
        }
    }
}