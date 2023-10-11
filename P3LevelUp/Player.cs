namespace P3LevelUp;

    public class Player
    {
        public int playerLvl = 0;
        public int playerExperience = 0;
        public int grantExperience(int expericence)
        {
            
            playerExperience += expericence;
            while (playerExperience > 100)
            {
                playerLvl++;
                playerExperience -= 100;

            }
            
            return playerExperience;
            
            
        }
    }

