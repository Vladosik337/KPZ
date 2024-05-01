class WeaponDecorator : HeroDecorator
{
    public WeaponDecorator(Hero hero) : base(hero)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + " with Weapon";
    }
}