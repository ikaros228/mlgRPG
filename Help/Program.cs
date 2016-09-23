using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Help
{
    class Program
    {
        static void Welcome(bool first)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            if (first == false)
            {
                Console.WriteLine("Привет, вы играете в игру 1.0ж...123.12.312.3 v.арбузики");
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("Для начала игры пропишите: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("start");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Вызова помощи пропишите: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("help");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Для выхода пропишите: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("exit");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Для вывода списка авторов пропишите: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("about");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string m1 = Console.ReadLine();
            switch (m1)
            {
                case "start":
                    //шыфоащгцурпш
                    Console.Clear();
                    Game();
                    break;
                case "help":
                    //helpa
                    Console.Clear();
                    Help();
                    //helpa
                    break;
                case "exit":
                    Console.Clear();
                    Console.WriteLine("Нажмите любую клавишу для выхода...");
                    Console.ReadKey();
                    break;
                case "about":
                    Console.Clear();
                    Authors();
                    break;
            }
        }
        static void Authors()
        {
            Console.WriteLine("Список авторов будет тута");
            Console.WriteLine("Список авторов будет тута");
            Console.WriteLine("Список авторов будет тута");
            Console.WriteLine("Список авторов будет тута");
            Console.WriteLine("Список авторов будет тута");
            Console.WriteLine("Список авторов будет тута");
            Console.WriteLine("Для возвращения пропешите back");
            string m3 = Console.ReadLine();
            switch (m3)
            {
                case "back":
                    Welcome(true);
                    break;
            }
        }
        static void Help()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("Правила");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Для возвращения в меню напишите back");
            Console.WriteLine("--------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string m2 = Console.ReadLine();
            switch (m2)
            {
                case "back":
                    Welcome(true);
                    break;
            }
        }
        static void Main(string[] args)
        {
            Welcome(false);
        }
        static void Game()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("В игре есть: Priest, Warrior, Mage, Bard, Warrior, Assasin, Hunter. Нажмите любую клавишу для игры.");
            Console.ReadLine();
            List<string> Characters = Show();
            GP();
        }
        static void GP()
        {
            do
            {
                // Console.WriteLine("Work in progress...");
                Show();
                MainTeamPuncker();
                break;
            }
            while (true);
        }

        static List<string> Show()
        {
            List<string> Characters = new List<string>();
            Characters.Add("priest");
            Characters.Add("mage");
            Characters.Add("bard");
            Characters.Add("warrior");
            Characters.Add("assasin");
            Characters.Add("hunter");
            return Characters;

        }
        static void MainTeamPuncker()
        {
            Console.Clear();
            List<string> player1 = new List<string>();
            List<string> player2 = new List<string>();
            string character = "";
            team_pucker(Show(), player1, character, player2);
        }
        static int queue = 1;
        static void team_pucker(List<string> characters, List<string> player1, string character, List<string> player2)
        {
            character = "";
            if (queue == 1)
            {
                if (player1.Count < 3)
                {
                    character = Console.ReadLine();
                    if (character.ToLower() == "priest")
                    {
                        if (player1.Contains("priest"))
                        {
                            Console.WriteLine("У Вас в команде уже есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                        else
                        {
                            player1.Add("priest");
                            characters.Remove("priest");
                            Console.WriteLine("Теперь у Вас в команде есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                    }
                    if (character.ToLower() == "bard")
                    {
                        if (player1.Contains("bard"))
                        {
                            Console.WriteLine("У Вас в команде уже есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                        else
                        {
                            player1.Add("bard");
                            characters.Remove("priest");
                            Console.WriteLine("Теперь у Вас в команде есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                    }
                    if (character.ToLower() == "mage")
                    {
                        if (player1.Contains("mage"))
                        {
                            Console.WriteLine("У Вас в команде уже есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                        else
                        {
                            player1.Add("mage");
                            characters.Remove("priest");
                            Console.WriteLine("Теперь у Вас в команде есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                    }
                    if (character.ToLower() == "warrior")
                    {
                        if (player1.Contains("warrior"))
                        {
                            Console.WriteLine("У Вас в команде уже есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                        else
                        {
                            player1.Add("warrior");
                            characters.Remove("priest");
                            Console.WriteLine("Теперь у Вас в команде есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                    }
                    if (character.ToLower() == "hunter")
                    {
                        if (player1.Contains("hunter"))
                        {
                            Console.WriteLine("У Вас в команде уже есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                        else
                        {
                            player1.Add("hunter");
                            characters.Remove("priest");
                            Console.WriteLine("Теперь у Вас в команде есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                    }
                    if (character.ToLower() == "assasin")
                    {
                        if (player1.Contains("assasin"))
                        {
                            Console.WriteLine("У Вас в команде уже есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                        else
                        {
                            player1.Add("assasin");
                            characters.Remove("priest");
                            Console.WriteLine("Теперь у Вас в команде есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                    }
                    if (character == "")
                    {
                        Console.WriteLine("Вы не ввели имя персонажа!");
                        team_pucker(Show(), player1, character, player2);
                    }
                    else
                    {
                        Console.WriteLine("Такого персонажа нет!");
                        team_pucker(Show(), player1, character, player2);
                    }

                }
                else
                {
                    queue = 2;
                    Console.WriteLine("Теперь очередь второго игрока!");
                    team_pucker(Show(), player1, character, player2);
                }
            }
            if (queue == 2)
            {
                if (player2.Count < 3)
                {
                    character = Console.ReadLine();
                    if (character.ToLower() == "priest")
                    {
                        if (player2.Contains("priest"))
                        {
                            Console.WriteLine("У Вас в команде уже есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                        else
                        {
                            player2.Add("priest");
                            characters.Remove("priest");
                            Console.WriteLine("Теперь у Вас в команде есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                    }
                    if (character.ToLower() == "bard")
                    {
                        if (player2.Contains("bard"))
                        {
                            Console.WriteLine("У Вас в команде уже есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                        else
                        {
                            player2.Add("bard");
                            characters.Remove("priest");
                            Console.WriteLine("Теперь у Вас в команде есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                    }
                    if (character.ToLower() == "mage")
                    {
                        if (player2.Contains("mage"))
                        {
                            Console.WriteLine("У Вас в команде уже есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                        else
                        {
                            player2.Add("mage");
                            characters.Remove("priest");
                            Console.WriteLine("Теперь у Вас в команде есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                    }
                    if (character.ToLower() == "warrior")
                    {
                        if (player2.Contains("warrior"))
                        {
                            Console.WriteLine("У Вас в команде уже есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                        else
                        {
                            player2.Add("warrior");
                            characters.Remove("priest");
                            Console.WriteLine("Теперь у Вас в команде есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                    }
                    if (character.ToLower() == "hunter")
                    {
                        if (player2.Contains("hunter"))
                        {
                            Console.WriteLine("У Вас в команде уже есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                        else
                        {
                            player2.Add("hunter");
                            characters.Remove("priest");
                            Console.WriteLine("Теперь у Вас в команде есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                    }
                    if (character.ToLower() == "assasin")
                    {
                        if (player2.Contains("assasin"))
                        {
                            Console.WriteLine("У Вас в команде уже есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                        else
                        {
                            player2.Add("assasin");
                            characters.Remove("priest");
                            Console.WriteLine("Теперь у Вас в команде есть " + character + "!");
                            team_pucker(Show(), player1, character, player2);
                        }
                    }
                    if (character == "")
                    {
                        Console.WriteLine("Вы не ввели имя персонажа!");
                        team_pucker(Show(), player1, character, player2);
                    }
                    else
                    {
                        Console.WriteLine("Такого персонажа нет!");
                        team_pucker(Show(), player1, character, player2);
                    }

                }
                else
                {
                    Console.WriteLine("Всё, команды собраны!");
                    Console.ReadLine();
                    Welcome(true);
                }
            }
        }
    }
}
