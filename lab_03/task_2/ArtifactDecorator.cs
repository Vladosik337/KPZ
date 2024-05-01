class ArtifactDecorator : HeroDecorator
{
    public ArtifactDecorator(Hero hero) : base(hero)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + " with Artifact";
    }
}