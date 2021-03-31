namespace Zoo
{
    public class Monkey : Animal
    {
        protected override int AnimalHealthLimit => 40;
        public override bool IsDead => this.Health < this.AnimalHealthLimit;
    }
}
