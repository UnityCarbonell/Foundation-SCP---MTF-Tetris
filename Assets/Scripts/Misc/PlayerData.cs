[System.Serializable]
public class PlayerData
{
    public int classicHighScore;
    public int pentaHighScore;
    public int caosHighScore;

    public PlayerData(GameManager gm)
    {
        classicHighScore = gm.classicHighScore;
        pentaHighScore = gm.pentaHighScore;
        caosHighScore = gm.caosHighScore;
    }
}
