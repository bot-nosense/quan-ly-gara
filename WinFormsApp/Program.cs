using WinFormsApp.MainScene;

namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new fLogin());

            // demo UI
            //Application.Run(new fItems());
            //Application.Run(new fItemInsertionReport());
            //Application.Run(new fHistoryImportItems());
            //Application.Run(new fImportItems());
            Application.Run(new fBill());
        }
    }
}