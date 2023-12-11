namespace MY_Game
{
    internal class FrontFace
    {
        public void User_Game()
        {


            Console.Clear();
            Heros_vs_Enemys();

            StartGame();
            Console.WriteLine();





            Fighters();


        }


        public void Fighters()
        {
            Console.WriteLine("\tFIGHTERS:", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("\t     HEROS:", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("\t\t1. Archer", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("\t\t2. Mage");
            Console.WriteLine("\t\t3. Warrior");
            Console.WriteLine("");
            Console.WriteLine("\t     ENEMYS:", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("\t\t1. Goblin", Console.ForegroundColor = ConsoleColor.DarkRed);
            Console.WriteLine("\t\t2. Witch");
            Console.WriteLine("\t\t3. Ork");

            Console.ForegroundColor = ConsoleColor.White;
        }




        public void Heros_vs_Enemys()
        {
            Console.WriteLine($@"           __  __  ____    ____    _____       __  __  ____        ____    __  __  ____              __    __  ____          ", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine($@"          /\ \/\ \/\  _`\ /\  _`\ /\  __`\    /\ \/\ \/\  _`\     /\  _`\ /\ \/\ \/\  _`\   /'\_/`\ /\ \  /\ \/\  _`\        ");
            Console.WriteLine($@"          \ \ \_\ \ \ \L\_\ \ \L\ \ \ \/\ \   \ \ \ \ \ \,\L\_\   \ \ \L\_\ \ `\\ \ \ \L\_\/\      \\ `\`\\/'/\ \,\L\_\      ");
            Console.WriteLine($@"           \ \  _  \ \  _\L\ \ ,  /\ \ \ \ \   \ \ \ \ \/_\__ \    \ \  _\L\ \ , ` \ \  _\L\ \ \__\ \`\ `\ /'  \/_\__ \      ");
            Console.WriteLine($@"            \ \ \ \ \ \ \L\ \ \ \\ \\ \ \_\ \   \ \ \_/ \/\ \L\ \   \ \ \L\ \ \ \`\ \ \ \L\ \ \ \_/\ \ `\ \ \    /\ \L\ \    ", Console.ForegroundColor = ConsoleColor.Yellow);
            Console.WriteLine($@"             \ \_\ \_\ \____/\ \_\ \_\ \_____\   \ `\___/\ `\____\   \ \____/\ \_\ \_\ \____/\ \_\\ \_\  \ \_\   \ `\____\   ");
            Console.WriteLine($@"              \/_/\/_/\/___/  \/_/\/ /\/_____/    `\/__/  \/_____/    \/___/  \/_/\/_/\/___/  \/_/ \/_/   \/_/    \/_____/   ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n");
        }



        public void StartGame()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. ");
        }
    }
}