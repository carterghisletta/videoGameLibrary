Player p = new Player("", 0, 0, 0);

p.userInfo();
p.addGame();
p.displayPlayerInfo();

class Player
{
    public string userName;
    public int level;
    public int totalGames;
    public double totalHoursPlayed;
    public List<Game> games = new List<Game>();

    public Player(string u, int l, int t, double h)
    {
        userName = u;
        level = l;
        totalGames = t;
        totalHoursPlayed = h;
    }

    public void userInfo()
    {
        Console.WriteLine("what is your username?");
        userName = Console.ReadLine();

        Console.WriteLine("what is your Level?");
        level = Convert.ToInt32(Console.ReadLine());
    }

    public void addGame()
    {
        Console.WriteLine("How many games would you like to add?");
        totalGames = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < totalGames; i++)
        {
            Console.WriteLine("what is the title?");
            string t = Console.ReadLine();

            Console.WriteLine("what is the genre?");
            string g = Console.ReadLine();

            Console.WriteLine("How many Hours Played?");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Rating 1 out of 10");
            string r = Console.ReadLine();

            Console.WriteLine("Is game completed? enter True/False: ");
            bool c = Convert.ToBoolean(Console.ReadLine());

            Game newgame = new Game(t, g, h, r, c);

            games.Add(newgame);

            totalHoursPlayed += h;
        }
    }

    public void displayPlayerInfo()
    {
        Console.WriteLine("PLAYER INFO:");
        Console.WriteLine("Username: {0}", userName);
        Console.WriteLine("Level: {0}", level);
        Console.WriteLine("Total Games: {0}", totalGames);
        Console.WriteLine("Total hours played: {0} ", totalHoursPlayed);

        Console.WriteLine("GAME LIBRARY");
        foreach (Game g in games)
        {
            g.displayGameInfo();
        }
    }
}

class Game
{
    string title;
    string genre;
    double hoursplayed;
    string rating;
    bool isCompleted;

    public Game(string t, string g, double h, string r, bool c)
    {
        title = t;        
        genre = g;        
        hoursplayed = h;  
        rating = r;       
        isCompleted = c;  
    }

    public void displayGameInfo()
    {
        Console.WriteLine("Title: {0}", title);
        Console.WriteLine("Genre: {0}", genre);
        Console.WriteLine("Hours Played: {0}", hoursplayed);
        Console.WriteLine("Rating: {0}", rating);
        Console.WriteLine("Completion: {0}", isCompleted);
    }
}