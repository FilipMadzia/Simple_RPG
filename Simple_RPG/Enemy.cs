namespace Simple_RPG {
    public class Enemy {
        private string name = "Enemy";
        private float strengthPoints;
        private float healthPoints;

        public Enemy(string _name, float strength, float health) {
            Name = _name;
            StrengthPoints = strength;
            HealthPoints = health;
        }

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public float StrengthPoints {
            get {
                return strengthPoints;
            }
            set {
                if(value > 0 && value <= 10) {
                    strengthPoints = value;
                }
            }
        }
        public float HealthPoints {
            get {
                return healthPoints;
            }
            set {
                if(value > 0 && value <= 100) {
                    healthPoints = value;
                }
            }
        }

        public void ReceiveDamage(float _damage) {
            if(healthPoints - _damage > 0) {
                healthPoints -= _damage;
            }
            else {
                Die();    
            }
        }
        private void Die() {
            healthPoints = 0;
            Console.WriteLine(name + " was killed.");
        }
    }
}
