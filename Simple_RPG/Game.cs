namespace Simple_RPG {
    class Game {
        static void Main(string[] args) {
            Player player = new Player(Player.PlayerClass.Knight, "Max the Warrior");
            Enemy enemy = new Enemy("Giant Dragon", 10, 100);

            Console.WriteLine(player.Name + " gets attacked by a(n) " + enemy.Name + "!");

            while (player.IsAlive) {
                Console.WriteLine(player.Name + " has " + player.HealthPoints + " HP");
                Console.WriteLine(enemy.Name + " has " + enemy.HealthPoints+ " HP");

                player.Fight(enemy);

                Console.ReadKey();
            }
        }
    }
}