namespace Simple_RPG {
    class Game {
        static void Main(string[] args) {
            Enemy enemy = new Enemy("Dragon", 10, 100);
            Enemy enemy2 = new Enemy("Goblin", 2, 15);

            Console.WriteLine(enemy.Health);

            enemy.ReceiveDamage(15);

            Console.WriteLine(enemy.Health);

            enemy.ReceiveDamage(90);

        }
    }
}