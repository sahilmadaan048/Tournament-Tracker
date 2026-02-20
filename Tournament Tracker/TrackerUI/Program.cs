using Microsoft.Extensions.Configuration;
using TrackerLibrary;

namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            // Initialize database connections
            //GlobalConfig.InitializeConnections(DatabaseType.Sql, config);
            GlobalConfig.InitializeConnections(DatabaseType.TextFile, config);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();

            ///
            /// keep in mind that the form that should be named as  TournamentViewerForm 
            /// is actually being served its action by the TournamentViewerLabel form, 
            /// which is the one that is being called in the Application.Run() method.
            /// so if we want to show / use the TournamentViewerForm form, we should call 
            /// the TournamentViewerLabel finction instead because of some stupid naming erro i did yesterday and 
            /// did not delete all the hidden filed properly before pushing the code to the github repo
            ///

            //Application.Run(new TournamentDashboardForm());
            //Application.Run(new TournamentViewerLabel());
            //Application.Run(new CreatePrizeForm());
            Application.Run(new CreateTeamForm());
            //Application.Run(new CreateTournamentForm());
        }
    }
}