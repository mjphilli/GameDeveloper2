class Enemy
{
    public string Name;
    public int MaxHealth;
    private int Health;
    public int _Health
    {
        get { return Health; }
        set { Health = value; }
    }
    public List<Attack> AttackList;

    public Enemy(string name, int health = 100)
    {
        Name = name;
        Health = health;
        MaxHealth = health;
        AttackList = new List<Attack>();
    }

    public Attack RandomAttack()
    {
        Random rand = new Random();
        return AttackList[rand.Next(AttackList.Count)];
    }

    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }

    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Health <= 0)
        {
            Console.WriteLine("You can't attack if you're dead!");
        }
        else if (Target.Health <= 0)
        {
            Console.WriteLine("You can't a dead target!");
        }
        else
        {
            Target.Health -= ChosenAttack.DamageAmount;
            Console.WriteLine($"{Name} attacks {Target.Name} using {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
        }

    }


}