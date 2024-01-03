namespace ChatApp.Presentation.ManagingMenus
{
    public class SubMenu
    {
        public void ShowMainMenu()
        {
            Menu m = new ();
            string[] options = { "GROUP CHANNELS", "PRIVATE MESSAGES", "USER MANAGEMENT",
            "PROFILE SETTINGS", "LOG OUT"};
            m.PrintMenu("CHAT", options, "SubMenu");
        }

        public void ExecuteSubMenuOptions(int index) 
        {
            switch (index)
            {
                case 0:
                    Console.Title = "GROUP CHANNELS";
                    //
                    break;
                case 1:
                    Console.Title = "PRIVATE MESSAGES";
                    //
                    break;
                case 2:
                    Console.Title = "USER MANAGEMENT";
                    //
                    break;
                case 3:
                    Console.Title = "PROFILE SETTINGS";
                    //
                    break;
                case 4:
                    Console.Title = "LOG OUT";
                    MainMenu mm = new();
                    mm.ShowMainMenu();
                    break;
                default:
                    break;
            }
        }
    }
}
