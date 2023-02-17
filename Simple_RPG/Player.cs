namespace Simple_RPG {
    public class Player {
        public enum PlayerClass {
            Knight,
            Wizard,
            Priest
        };

        private string name;
        private float strengthPoints;
        private float healthPoints;
        private float magicPoints;
        private bool isAlive = true;

        public Player(PlayerClass playerClass, string _name) {
            name = _name;
            if(playerClass.Equals(PlayerClass.Knight)) {
                strengthPoints = 5f;
                healthPoints = 50f;
                magicPoints = 0f;
            }
        }

        public string Name {
            get {return name;}
        }
        public float StrengthPoints {
            get {return strengthPoints;}
        }
        public float HealthPoints {
            get {return healthPoints;}
        }
        public float MagicPoints{
            get {return magicPoints;}
        }
        public bool IsAlive {
            get {return isAlive;}
        }

        public void Fight(Enemy enemy) {
            Random rndBonus = new Random();
            float playerBonus = rndBonus.Next(0, (int)strengthPoints);
            float enemyBonus= rndBonus.Next(0, (int)enemy.StrengthPoints);

            enemy.ReceiveDamage(strengthPoints + playerBonus);
            healthPoints -= enemy.StrengthPoints + enemyBonus;

            Console.WriteLine(name + " deals " + (strengthPoints + playerBonus) + " DMG to " + enemy.Name);
            Console.WriteLine(enemy.Name+ " deals " + (enemy.StrengthPoints + enemyBonus) + " DMG to " + name);

            if(healthPoints <= 0) {
                Die(enemy);
            }
        }

        public void Die(Enemy enemy) {
            Console.WriteLine(name + " died while fighting " + enemy.Name);
            isAlive = false;
        }
    }
}
