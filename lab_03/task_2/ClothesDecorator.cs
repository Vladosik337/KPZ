class ClothesDecorator : HeroDecorator
{
    public ClothesDecorator(Hero hero) : base(hero)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + " with Clothes";
    }
}