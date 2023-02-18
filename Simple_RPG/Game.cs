namespace Simple_RPG {
    class Game {
        static void Main(string[] args) {
            // player customization
            Console.WriteLine("Customize your character");
            Console.WriteLine("Choose player class: ");
            int classI = 1;
            foreach(var Class in Enum.GetNames<Player.PlayerClass>()) {
                Console.WriteLine(classI + ". " + Class);
                classI++;
            }


            Enemy enemy = new Enemy("Giant Dragon", 10, 100);

            //while (player.IsAlive) {
              //  player.Stats();
                //player.Fight(enemy);
            //}
        }
    }
}