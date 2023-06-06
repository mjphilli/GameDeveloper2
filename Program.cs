MeleeFighter aragorn = new MeleeFighter("Aragorn");
RangedFighter legolas = new RangedFighter("Legolas");
MagicCaster gandalf = new MagicCaster("Gandalf");

aragorn.PerformAttack(legolas, aragorn.AttackList[1]);
aragorn.PerformAttack(gandalf, aragorn.Rage());
legolas.PerformAttack(aragorn, legolas.AttackList[0]);
legolas.Dash();
legolas.PerformAttack(aragorn, legolas.AttackList[0]);
gandalf.PerformAttack(aragorn, gandalf.AttackList[0]);
gandalf.Heal(legolas);
gandalf.Heal(gandalf);