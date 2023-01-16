public class Level : User
{
    public static int CurrentLevel = 0;
    public static int requiredExperience = 2;
    public static int XP = 0;
    
    public static void CurrentLevelInformation()
    {
        UpdateLevel();
        Console.WriteLine("Текущий уровень: " + CurrentLevel);
        Console.WriteLine("Текущее кол-во опыта: " + XP + "/" + requiredExperience);
        
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
                CurrentLevel++;
                requiredExperience *= 2;
            }
            else
            {
                flag = false;
            }
        }
    }
}