namespace Simple_RPG {
    public class Enemy {
        private string name = "Enemy";
        private float strength;
        private float health;

        public Enemy(string _name, float _strength, float _health) {
            Name = _name;
            Strength = _strength;
            Health = _health;
        }

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public float Strength {
            get {
                return strength;
            }
            set {
                if(value > 0 && value <= 10) {
                    strength = value;
                }
            }
        }
        public float Health {
            get {
                return health;
            }
            set {
                if(value > 0 && value <= 100) {
                    health = value;
                }
            }
        }

        public void ReceiveDamage(float _damage) {
            if(health - _damage > 0) {
                health -= _damage;
            }
            else {
                Die();    
            }
        }
        private void Die() {
            health = 0;
            Console.WriteLine(name + " was killed.");
        }
    }
}
