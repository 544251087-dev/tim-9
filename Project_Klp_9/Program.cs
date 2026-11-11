using Project_Klp_9.Models;
using Project_Klp_9.Presenter;

namespace Project_Klp_9
{
    internal static class Program
    {
        public static Model currentUser; // Menyimpan data pengguna yang login
        public static UserRepository userRepository = new UserRepository(); // Instance UserRepository untuk digunakan di seluruh aplikasi
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