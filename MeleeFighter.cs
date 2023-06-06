class MeleeFighter : Enemy
{
    public MeleeFighter(string name) : base(name, 120)
    {
        AttackList.Add(new Attack("Punch", 20));
        AttackList.Add(new Attack("Kick", 15));
        AttackList.Add(new Attack("Tackle", 25));
    }

    public Attack Rage()
    {
        Attack rageAttack = RandomAttack();
        rageAttack.DamageAmount += 10;
        return rageAttack; 
    }
}