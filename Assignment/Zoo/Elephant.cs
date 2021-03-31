namespace Zoo
{
    public class Elephant : Animal
    {
        protected override int AnimalHealthLimit => 70;

        public override void Starving(int hpToRemove)
        {
            if (this.Health < this.AnimalHealthLimit)
            {
                this.IsDead = true;
            }

            base.Starving(hpToRemove);
        }
    }
}
