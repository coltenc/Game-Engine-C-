namespace Game_Engine
{
    internal class Program
    {
        public static bool isGaming = true;
        public static bool is2D = false; //if is2D then it is 3d.
        public static int outputPages = 0;

        static void Main(string[] args)
        {
            if (is2D)
            {
                Frames2.page1();
            }
            else
            {
                Frames3.page1();
            }


            while (isGaming)
            {
                switch (outputPages)
                {
                    //main menu
                    case 0:
                        Console.Clear();
                        GlobalPages.MainMenu();
                        Inputs.KeyPressed();
                        break;

                     //Pause Menu
                    case 1:
                        Console.Clear();
                        GlobalPages.PauseMenu();
                        Inputs.KeyPressed();
                        break;

                    //Options Menu
                    case 2:
                        Console.Clear();
                        GlobalPages.OptionsMenu();
                        Inputs.KeyPressed();
                        break;

                    //game pages
                    case 3:
                        if (is2D)
                        {
                            Console.Clear();
                            Frames2.page1();
                            Inputs.KeyPressed();
                        } else
                        {
                            Console.Clear();
                            Frames3.page1();
                            Inputs.KeyPressed();
                        }
                        break;
                }
            }
        }
    }
}
