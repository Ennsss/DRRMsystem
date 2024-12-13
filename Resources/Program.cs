namespace DRRMSystem
{
    internal static class Program
    {
        public static ApplicationConfiguration AppConfig { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize application configuration
            AppConfig = new ApplicationConfiguration();
            AppConfig.Initialize();

            Application.Run(new FormLogin());
        }
    }

    internal class ApplicationConfiguration
    {
        public void Initialize()
        {
            // Initialize application configuration here
        }
    }
}
