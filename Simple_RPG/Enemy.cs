namespace Simple_RPG {
    public class Enemy {
        private string name;
        private float strength;
        private float health;

        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }
        public float Strength {
            get {
                return this.strength;
            }
            set {
                this.strength = value;
            }
        }
        public float Health {
            get {
                return this.health;
            }
            set {
                this.health = value;
            }
        }
    }
}
