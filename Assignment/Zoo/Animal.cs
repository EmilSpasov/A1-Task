using Common;

namespace Zoo
{
    public abstract class Animal
    {
        protected Animal()
        {
            this.Health = GlobalConstants.InitialHealthPoints;
        }

        protected virtual int AnimalHealthLimit { get; set; }

        protected int Health { get; set; }

        public bool IsDead { get; protected set; }

        public virtual void Starving(int hpToRemove)
        {
            this.Health -= hpToRemove;

            if (this.Health < GlobalConstants.MinHealth)
            {
                this.Health = GlobalConstants.MinHealth;
            }

            if (this.Health < this.AnimalHealthLimit)
            {
                this.IsDead = true;
            }
        }

        public void Feed(int hpToRecover)
        {
            this.Health += hpToRecover;

            if (this.Health > GlobalConstants.MaxHealth)
            {
                this.Health = GlobalConstants.MaxHealth;
            }
        }
    }
}
