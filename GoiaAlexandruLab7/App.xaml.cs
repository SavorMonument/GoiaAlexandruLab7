using GoiaAlexandruLab7.Data;
using Microsoft.Extensions.DependencyInjection;

namespace GoiaAlexandruLab7
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;

        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ShoppingListDatabase(
                        Path.Combine(FileSystem.AppDataDirectory, "ShoppingList.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}