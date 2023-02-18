namespace Simple_RPG {
    public class Player {
        public enum PlayerClass {
            Knight = 1,
            Wizard = 2,
            Priest = 3
        };

        private string name;
        private string? playerClass;
        private float strengthPoints;
        private float healthPoints;
        private float magicPoints;
        private bool isAlive = true;

        public Player(PlayerClass _playerClass, string _name) {
            name = _name;
            if(_playerClass.Equals(PlayerClass.Knight)) {
                playerClass = PlayerClass.Knight.ToString();
                strengthPoints = 8f;
                healthPoints = 50f;
                magicPoints = 0f;
            }
            else if(_playerClass.Equals(PlayerClass.Priest)) {
                playerClass = PlayerClass.Priest.ToString();
                strengthPoints = 3f;
                healthPoints = 50f;
                magicPoints = 5f;
            }
            else if(_playerClass.Equals(PlayerClass.Knight)) {
                playerClass = PlayerClass.Knight.ToString();
                strengthPoints = 3f;
                healthPoints = 40f;
                magicPoints = 15f;
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

        public void Stats() {
            Console.Clear();
            Console.WriteLine(name +  ", " + playerClass);
            Console.WriteLine("HP: " + healthPoints + " Strength: " + strengthPoints + " Magic: " + magicPoints + "\n");

        }

        public void Fight(Enemy enemy) {
            Console.WriteLine(name + " gets attacked by a " + enemy.Name + "! (" + enemy.HealthPoints + "HP " + enemy.StrengthPoints + " strength)");
            float enemyHPBase = enemy.HealthPoints;
            float enemyStrengthBase = enemy.StrengthPoints;

            if(magicPoints >= 5) {
                Console.WriteLine(name + "'s magic is over 5. " + name + " can try skipping this fight!");
                Console.Write("Do you want to try? (y/n)");

                string? choice;
                choice = Console.ReadLine();

                if(choice == "y") {
                    Random skipRnd = new Random();
                    float skipChance = skipRnd.Next(5, 20);

                    if(magicPoints >= skipChance) {
                        Console.WriteLine(name + " succesfully skipped the fight!\n");
                        Continue();
                        return;
                    }
                    else {
                        Console.WriteLine("This time " + name + " has to fight.\n");
                    }
                }
                else {
                    Console.WriteLine(name + " decided to fight.\n");
                }
            }

            while (isAlive) {
                Stats();
                Random rndBonus = new Random();
                float playerBonus = rndBonus.Next(0, (int)strengthPoints);
                float enemyBonus= rndBonus.Next(0, (int)enemy.StrengthPoints);

                enemy.ReceiveDamage(strengthPoints + playerBonus);
                healthPoints -= enemy.StrengthPoints + enemyBonus;

                Console.WriteLine(name + " deals " + (strengthPoints + playerBonus) + " DMG to " + enemy.Name + "(" + enemy.HealthPoints + "/" + enemyHPBase + "HP)");
                Console.WriteLine(enemy.Name+ " deals " + (enemy.StrengthPoints + enemyBonus) + " DMG to " + name);

                if(healthPoints <= 0) {
                    Die(enemy);
                }

                Continue();
            }
        }

        public void Die(Enemy enemy) {
            Console.WriteLine(name + " died while fighting " + enemy.Name);
            isAlive = false;
        }

        private void Continue() {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
