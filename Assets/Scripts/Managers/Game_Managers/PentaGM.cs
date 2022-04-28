using UnityEngine;

public class PentaGM : GameManager
{
    protected override void LoadDataToGM()
    {
        PlayerData playerData = SaveManager.LoadData();
        pentaHighScore = playerData.pentaHighScore;
        Debug.Log("Data loaded.");
    }
    protected override void SaveDataFromGM()
    {
        pentaHighScore = score;
        SaveManager.SavePlayerData(this);
        Debug.Log("Data Saved.");
    }
    protected override void GameOver()
    {
        generator.SetActive(false);
        gameOver.SetTrigger("GameOver");
        if (score > pentaHighScore)
        {
            SaveDataFromGM();
            FinalScore.text = "Your new Best score is " + score.ToString() + "." +
           "\n Good Job!";
        }
        else
        {
            FinalScore.text = "Your final score is " + score.ToString() + "." +
         "\n Your Best score is " + pentaHighScore.ToString() + ".";
        }
    }
}