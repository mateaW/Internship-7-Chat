namespace ChatApp.Presentation.ManagingMenus
{
    public class Menu
    {
        public void PrintMenu(string title, string[] options, string menuType)
        {
            Console.Title = title;
            string[] menuOptions = options;
            int selectedOptionIndex = 0;

            while (true)
            {
                Console.Clear();

                // print all options
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    if (i == selectedOptionIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // set color for selected option
                    }

                    Console.WriteLine($"[{i + 1}] {menuOptions[i]}");

                    Console.ResetColor(); // reset color
                }

                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedOptionIndex = Math.Max(0, selectedOptionIndex - 1);
                        break;

                    case ConsoleKey.DownArrow:
                        selectedOptionIndex = Math.Min(menuOptions.Length - 1, selectedOptionIndex + 1);
                        break;

                    case ConsoleKey.Enter:
                        Console.Clear();
                        // execute selected option
                        if (menuType == "MainMenu")
                        {
                            MainMenu mmo = new();
                            mmo.ExecuteMainMenuOptions(selectedOptionIndex);
                        }
                        else if (menuType == "SubMenu")
                        {
                            SubMenu smo = new();
                            smo.ExecuteSubMenuOptions(selectedOptionIndex);
                        }   
                        Console.ReadKey();
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
