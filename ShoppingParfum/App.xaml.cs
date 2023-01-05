using ShoppingParfum;

namespace ShoppingParfum;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new LoginPage();
    }
        static LoginDb database;

    // Create the database connection as a singleton.
    public static LoginDb Database
    {
        get
        {
            if (database == null)
            {
                database = new LoginDb(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SQLLiteSample.db"));
            }
            return database;
        }
    }
}