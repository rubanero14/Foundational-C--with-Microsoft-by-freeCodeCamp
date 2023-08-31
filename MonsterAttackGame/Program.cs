int heroHealth = 10;
int monsterHealth = 10;

bool heroTurn = true;
Random random = new Random();

do
{
    int attackPoints = random.Next(1, 11);

    if (heroTurn == true)
    {
        monsterHealth -= attackPoints;
        Console.WriteLine($@"Monster was damaged and lost {attackPoints} health and now has {monsterHealth} health.");
        heroTurn = false;
    }
    else 
    {
        heroHealth -= attackPoints;
        Console.WriteLine($@"Hero was damaged and lost {attackPoints} health and now has {heroHealth} health.");
        heroTurn = true;
    }

} while (heroHealth >= 0 && monsterHealth > 0);

if (heroHealth <= 0)
    Console.WriteLine("Monster Wins!");
else if (monsterHealth <= 0)
    Console.WriteLine("Hero Wins!");

