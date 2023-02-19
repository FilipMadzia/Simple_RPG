namespace Simple_RPG {
    class Game {
        static void Main(string[] args) {
            // player customization
            Console.WriteLine("Customize your character");
            Console.WriteLine("Choose player's class: ");
            int classI = 1;
            foreach(var Class in Enum.GetNames<Player.PlayerClass>()) {
                Console.WriteLine(classI + ". " + Class);
                classI++;
            }

            int playerClassIndex;
            Player.PlayerClass playerClass = new Player.PlayerClass();
            Console.Write("Class: ");
            playerClassIndex = int.Parse(Console.ReadLine());
            switch (playerClassIndex) {
                case 1:
                    playerClass = Player.PlayerClass.Knight;
                    break;
                case 2:
                    playerClass = Player.PlayerClass.Wizard;
                    break;
                case 3:
                    playerClass = Player.PlayerClass.Priest;
                    break;
            }

            Console.Write("Choose player's name: ");
            string? playerName;
            playerName = Console.ReadLine();

            Player player = new Player(playerClass, playerName);


            Enemy enemy = new Enemy("Giant Dragon", 10, 100);

            while (player.IsAlive) {
                player.Stats();
                player.Fight(enemy);
            }
        }
    }
}