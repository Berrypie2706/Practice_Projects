using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEndProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                try
                {
                    OnedayTeam player = new OnedayTeam();
                    Console.WriteLine("Choose the Operation:\n  1. Add Player \n 2. Remove Player \n 3. Get Player By Id \n 4. Get Player By Name \n 5. See players List");
                    int op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            {

                                Console.WriteLine("Enter Player Id");
                                int Id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Player Name");
                                string Name = Console.ReadLine();
                                Console.WriteLine("Enter Age");
                                int Age = int.Parse(Console.ReadLine());
                                player.Add(new Player { PlayerId = Id, PlayerName = Name, PlayerAge = Age });
                                break;
                            }
                        case 2:

                            {
                                Console.WriteLine("Enter Id of the player to remove");
                                int id = int.Parse(Console.ReadLine());
                                player.Remove(id);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Enter Player Id to get details:");
                                int playerIdToGet = int.Parse(Console.ReadLine());
                                Player playerById = player.GetPlayerById(playerIdToGet);
                                if (playerById != null)
                                {

                                    Console.WriteLine($"Player Found: Id: {playerById.PlayerId}, Name: {playerById.PlayerName}, Age: {playerById.PlayerAge}");
                                }
                                else
                                {
                                    Console.WriteLine("Player not found.");
                                }
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Enter Name of the Players to get details:");
                                string name = Console.ReadLine();
                                List<Player> listofplayers = player.GetPlayerByName(name);
                                if (listofplayers.Count > 0)

                                {
                                    foreach (Player p in listofplayers)
                                    {
                                        Console.WriteLine($"Player Deatils: \n  Id: {p.PlayerId}, Name: {p.PlayerName}, Age: {p.PlayerAge}");
                                    }

                                }

                            }
                            break;

                        case 5:
                            {
                                Console.WriteLine("List of players");
                                List<Player> list = player.GetAllPlayers();
                                foreach (Player p in list)
                                {
                                    Console.WriteLine($"ID: {p.PlayerId}\n Name: {p.PlayerName}\n Player Age: {p.PlayerAge}");
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid option");
                                break;
                            }
                    }
                }


                catch (ArgumentException e)
                {
                    Console.WriteLine("Argument Exception" + e.Message);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine("Null Reference exception :" + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error!!!" + e.Message);
                }

                Console.WriteLine("Press Y to Continue");
                choice = Console.ReadLine();
            }
          while (choice == "Y" || choice == "y");
            Console.ReadKey();

        }
    }
}
