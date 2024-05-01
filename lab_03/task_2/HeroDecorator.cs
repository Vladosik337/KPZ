abstract class HeroDecorator : Hero
{
    protected Hero hero;

    public HeroDecorator(Hero hero)
    {
        this.hero = hero;
    }

    public override string GetDescription()
    {
        return hero.GetDescription();
    }
}