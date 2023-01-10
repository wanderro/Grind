public class Level : User
{
    public static int currentLevel = 0;
    public static int requiredExperience = 2;
    public static int XP = 0;
    
    public static void CurrentLevelInformation()
    {
        UpdateLevel();
        Console.WriteLine(currentLevel);
        Console.WriteLine(XP);
    }

    public static void AddXP(int count)
    {
        XP += count;
    }

    private static void UpdateLevel()
    {
        var flag = true;
        while (flag)
        {
            if (XP >= requiredExperience)
            {
                currentLevel++;
                requiredExperience *= 2;
            }
            else
            {
                flag = false;
            }
        }
    }
}