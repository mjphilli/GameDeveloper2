class MagicCaster : Enemy
{
    public MagicCaster(string name) : base(name, 80)
    {
        AttackList.Add(new Attack("Fireball", 25));
        AttackList.Add(new Attack("Lightning Bolt", 20));
        AttackList.Add(new Attack("Staff Strike", 10));
    }

    public void Heal(Enemy Target)
    {
        if (Target._Health + 40 <= Target.MaxHealth)
        {
            Target._Health += 40;
        }
        else
        {
            Target._Health = Target.MaxHealth;
        }
        
        Console.WriteLine($"{Name} heals {Target.Name} to {Target._Health} health!");
    }
}