namespace MiniKata3;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int playerLuck = random.Next(1, 11);
        bool isAcceptedInput = false;
        
        while (!isAcceptedInput) {
            Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
            string userInput = Console.ReadLine()!.ToLower();
            
            if (userInput == "yes") {
                Console.WriteLine("Attempting to attack ...");
                
                // Attempting to not use if/else if/else statement
                string attackResult = playerLuck switch {
                    > 7 => "Success! You hit the enemy",
                    6 => "Success! You barely hit! You try to steel your focus",
                    _ => "Fail! You brace for impact"
                };
                Console.WriteLine(attackResult);
                isAcceptedInput = true;
            } else if (userInput == "no") {
                Console.WriteLine("You retreat! ...");
                isAcceptedInput = true;
            } else {
                Console.WriteLine("\nPlease enter a valid option!");
            }
        }
    }
}