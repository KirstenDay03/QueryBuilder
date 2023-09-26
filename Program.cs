namespace QueryBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pokemon p = new Pokemon();
            BannedGame bg = new BannedGame();

            QueryBuilder qb = new QueryBuilder("\"D:\\CSCI2910\\Labs\\QueryBuilder\\QueryBuilder\\Data\\data.db\"");

            Console.WriteLine("--------------------");
            Console.WriteLine("Deleting all records");
            Console.WriteLine("--------------------");

            qb.DeleteAll(p);
            Console.WriteLine("All Pokemon deleted.");
            Console.WriteLine();

            qb.DeleteAll(bg);
            Console.WriteLine("All banned games deleted.");
            Console.WriteLine();
            Console.WriteLine("--------------------");

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Adding Pokemon to a database from a collection");
            Console.WriteLine("----------------------------------------------");

            List<Pokemon> team = new List<Pokemon>();

            Pokemon delphox = new Pokemon(5, 655, "Delphox", "", "Fire", "Psychic", 534, 75, 69, 72, 114, 100, 104, 6);
            Pokemon charizard = new Pokemon(1, 6, "Charizard", "Mega Charizard Y", "Fire", "Flying", 634, 78, 104, 78, 159, 115, 100, 6);
            Pokemon gogoat = new Pokemon(6,  673, "Gogoat", "", "Grass", "", 531, 123, 100, 62, 97, 81, 68, 6);
            Pokemon lapras = new Pokemon(2, 131, "Lapras", "", "Water", "Ice", 535, 130, 85, 80, 85, 95, 60, 1);
            Pokemon lucario = new Pokemon(4, 448, "Lucario", "Mega Lucario", "Fighting", "Steel", 625, 70, 145, 88, 140, 70, 112, 4);
            Pokemon yveltal = new Pokemon(7, 717, "Yveltal", "", "Dark", "Flying", 680, 126, 131, 95, 131, 98, 99, 6);

            team.Add(gogoat);
            team.Add(lapras);
            team.Add(yveltal);
            team.Add(delphox);
            team.Add(charizard);
            team.Add(lucario);
             for(int x = 0; x < team.Count; x++)
            {
                qb.Create(team[x]);
                Console.WriteLine($"{team[x].name} was added to the database from the team list.");
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------");


            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Adding Banned Games to a database from a collection");
            Console.WriteLine("---------------------------------------------------");

            List<BannedGame> banned = new List<BannedGame>();

            BannedGame carmageddon = new BannedGame(1, "Carmageddon", "Carmageddon", "United Kingdom", "Was threatened with being refused certification in its uncut form. Was subsequently altered to replace humans with zombies. The restriction was later lifted and a patch was released to restore the original human content.");
            BannedGame doom = new BannedGame(2, "Doom", "Doom", "Brazil", "Banned because of very high impact violence and offensive depictions of cruelty.");
            BannedGame halfLife = new BannedGame(3, "Half-Life", "Half-Life", "Singapore", "Banned because of excessive violence. The ban was met with uproar as the local gaming community and retailers scrambled to start petitions to save the game. The government decided to lift the ban after a week as the game had been released for more than a year and the ban will impact the local LAN gaming and retail market.");

            banned.Add(carmageddon);
            banned.Add(doom);
            banned.Add(halfLife);

            for (int x = 0; x < banned.Count; x++)
            {
                qb.Create(banned[x]);
                Console.WriteLine($"{banned[x].title} was added to the database from the banned list.");
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Adding a single Pokemon to the database");
            Console.WriteLine("---------------------------------------");

            Pokemon kyogre = new Pokemon(3, 382, "Kyogre", "Primal Kyogre", "Water", "", 770, 100, 150, 90, 180, 160, 90, 3);
            qb.Create(kyogre);
            Console.WriteLine($"{kyogre.name} was added to the database.");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Adding a single Banned Game to the database");
            Console.WriteLine("--------------------------------------------");

            BannedGame mercenariesI = new BannedGame(4, "Mercenaries I: Playground of Destruction", "Mercenaries I", "South Korea", "Banned to avoid increasing diplomatic tensions with North Korea. Later lifted.");
            qb.Create(mercenariesI);
            Console.WriteLine($"{mercenariesI.title} was added to the database.");

            Console.WriteLine("--------------------------------------------");
        }
    }
}