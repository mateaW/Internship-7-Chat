using ChatApp.Domain.Repositories;

namespace ChatApp.Presentation.ManagingMenus
{
    public class MainMenu
    {
        public void ShowMainMenu()
        {
            Menu m = new ();
            string[] options = { "LOG IN", "SIGN UP", "CLOSE APP" };
            m.PrintMenu("CHAT", options, "MainMenu");
        }

        public void ExecuteMainMenuOptions(int index)
        {
            switch (index)
            {
                case 0:
                    Console.Title = "LOG IN";
                    UserRepository u = new();
                    u.LogIn();
                    SubMenu sm = new();
                    sm.ShowMainMenu();
                    break;
                case 1:
                    Console.Title = "SIGN UP";
                    break;
                case 2:
                    Console.WriteLine("Closing application...");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
