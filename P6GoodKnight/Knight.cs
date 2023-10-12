public class Knight
{
    public Shield? shield;
    public Sword? sword;

    public void GetHit(Sword? enemyWeapon)
    {
        if (shield == null)
        {
            Console.WriteLine("The Knight has no Shield and is wounded.");
        }
        else
        {
            if (enemyWeapon == null)
            {
                Console.WriteLine("Knights Shield fends off the strike.");
            }

            else
            {
                shield = null;
                Console.WriteLine("Shield was pierced by the Sword.");
            }
        }
    }

    public void Attack(Knight target)
    {
        if (sword == null)
        {
            Console.WriteLine($"Knight Attacks Knight with Bare Hands");
        }
        else
        {
            Console.WriteLine("Knight attacks Knight with a Sword.");
        }

        target.GetHit(this.sword);
    }
}