class RangedFighter : Enemy
{
    private int Distance;
    public RangedFighter(string name) : base(name)
    {
        Distance = 5;
        AttackList.Add(new Attack("Shoots an Arrow", 20));
        AttackList.Add(new Attack("Throw a Knife", 15));
    }

    public void Dash()
    {
        Distance = 20;
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Distance < 10)
        {
            Console.WriteLine("A ranged enemy cannot perform an attack if Distance is less than 10"!);
        }
        else
        {
            base.PerformAttack(Target, ChosenAttack);
        }

    }
}