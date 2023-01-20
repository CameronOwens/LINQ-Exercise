namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "Madden", "NBA2K", "God of War", "Call of Duty", "Mario Kart" };

            IEnumerable<string> gameOrder = games.OrderBy(str => str.Length).ThenBy(str => str);

            foreach (string game in gameOrder)
                Console.WriteLine(game);

            Console.ReadLine();
            
        }
    }
}
