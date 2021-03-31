namespace Zoo
{
    public class Lion : Animal
    {
        protected override int AnimalHealthLimit => 50;
        public override bool IsDead => this.Health < this.AnimalHealthLimit;
    }
}
