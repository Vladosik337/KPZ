class Program
{
    static void Main(string[] args)
    {
        Hero warrior = new Warrior();
        Hero mage = new Mage();
        Hero paladin = new Paladin();

        Hero decoratedWarrior = new ClothesDecorator(new WeaponDecorator(warrior));
        Hero decoratedMage = new WeaponDecorator(new ArtifactDecorator(mage));
        Hero decoratedPaladin = new ArtifactDecorator(new ClothesDecorator(paladin));

        Console.WriteLine("Warrior: " + decoratedWarrior.GetDescription());
        Console.WriteLine("Mage: " + decoratedMage.GetDescription());
        Console.WriteLine("Paladin: " + decoratedPaladin.GetDescription());
    }
}