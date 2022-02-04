using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino2;
using Casino2.TwentyOne;

namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidAnswer = false;
            int bank = 0;

            Console.WriteLine("Welcome to Casino de Matt. Let's start by telling me your name: ");
            string playerName = Console.ReadLine();

            while (!isValidAnswer)
            {
                Console.WriteLine("How much money did you bring today?");
                string amount = Console.ReadLine();
                isValidAnswer = int.TryParse(amount, out bank);
                if (!isValidAnswer)
                {
                    Console.WriteLine("Please enter a number with digits and decimals only");
                }
                
            }


            Console.WriteLine("Hello {0}, would you like to play Black Jack?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.ID = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Matt\OneDrive\Documents\GitHub\C_Sharp_Projects\Basic_C#_Projects\BlackJack_App\Black_Jack\Log.txt", true))
                {
                    file.WriteLine(player.ID);
                }
                Game game = new TwentyOneGame();  //used to expose the overloaded methods
                game += player; //What part of the game is this player being added to?
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try 
                    {

                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDBOExceptions(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex) //note, this exception can take a FraudException. This is another example of polymorphism
                    {
                        Console.WriteLine("An error occured, please contact your administrator.");
                        UpdateDBOExceptions(ex);
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing");

            }
            Console.WriteLine("Please feel free to look around the casino!");
            Console.Read();
        }


        private static void UpdateDBOExceptions(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                       Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                       TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar); //this is naming the data type "ExceptionType" as a varChar which is how we protect from SQL Injections
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); //we use GetType because that is what we want to store here, we convert it to string as it is originally not
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
       
    }
}
