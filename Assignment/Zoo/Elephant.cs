namespace Zoo
{
    public class Elephant : Animal
    {
        protected override int AnimalHealthLimit => 70;

        public bool CanWalk { get; private set; } = true;

        public override void Starving(int hpToRemove)
        {
            base.Starving(hpToRemove);

            if (this.IsDead && this.CanWalk)
            {
                this.IsDead = false;
                this.CanWalk = false;
            }
        }
    }
}
