using Common;

namespace Zoo
{
    public abstract class Animal
    {
        private const int health = GlobalConstants.InitialHealthPoints;
        private const int maxHealth = GlobalConstants.MaxHealth;
        private const int minHealth = GlobalConstants.MinHealth;

        protected Animal()
        {
            this.Health = health;
        }

        protected virtual int AnimalHealthLimit { get; set; }

        protected int Health { get; set; }

        public virtual bool IsDead { get; protected set; }

        public virtual void Starving(int hpToRemove)
        {
            this.Health -= hpToRemove;
            if (this.Health < minHealth)
            {
                this.Health = minHealth;
            }
        }

        public void Feed(int hpToRecover)
        {
            this.Health += hpToRecover;
            if (this.Health > maxHealth)
            {
                this.Health = maxHealth;
            }
        }
    }
}
