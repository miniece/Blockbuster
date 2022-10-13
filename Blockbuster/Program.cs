namespace BlockbusterLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blockbuster blockbuster = new Blockbuster();
            blockbuster.Movies = new List<Movie>();
            blockbuster.Movies.Add(new DVD("The Haunting of Your Mom", Categories.Horror, 95));
            blockbuster.Movies.Add(new DVD("Barbie Dumps Ken", Categories.Drama, 60));
            blockbuster.Movies.Add(new DVD("Jackbutt", Categories.Comedy, 79));
            blockbuster.Movies.Add(new VHS("Marvel and Xmen", Categories.Action, 87));
            blockbuster.Movies.Add(new VHS("Jason and Freddie Reunite", Categories.Romance, 69));
            blockbuster.Movies.Add(new VHS("Dora Swipes Back", Categories.Horror, 75));

            List<string> Scenes = new List<string>();
            Scenes.Add("Barbie jumps in the pool and drips acid on everyone.");
            Scenes.Add("IT the Clown comes and brings everyone cupcakes.");
            Scenes.Add("WonderPets eats Chuckie's homework.");

            Console.WriteLine("Welcome to Minnie's Blockbuster.");
            Console.WriteLine("");
            Console.WriteLine("Please select a movie from the list:");
            Blockbuster.PrintMovies(blockbuster.Movies);
            Console.WriteLine("");

            Console.WriteLine("Please select a movie you want to watch.");
            int selectMovie = int.Parse(Console.ReadLine());
            Movie.PrintInfo(blockbuster.Movies[selectMovie]);
            Console.WriteLine("");

            Console.WriteLine("Do you want to watch the movie? Type 'y' or 'n'");
            string watchMovie = Console.ReadLine().ToLower();
            if (watchMovie == "y")
            {
                Console.WriteLine("Which scene would you like to watch? Select 1 through 3");
                int selectScene = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine($"{Scenes[selectScene - 1]}");
                Console.WriteLine("");

                Console.WriteLine("Watch another scene?");
                string watchAnotherScene = Console.ReadLine();
                if (watchAnotherScene == "y")
                {
                    Console.WriteLine("Which scene would you like to watch? Select 1 through 3");
                    selectScene = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine($"{Scenes[selectScene - 1]}");
                    Console.WriteLine("");
                }
                


            }
            Console.WriteLine("");
            Console.WriteLine("Bye!");

            
        }
    }
}