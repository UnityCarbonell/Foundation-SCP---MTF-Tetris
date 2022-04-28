using UnityEngine;
public class CaosGM : GameManager
{
    protected override void LoadDataToGM()
    {
        PlayerData playerData = SaveManager.LoadData();
        caosHighScore = playerData.caosHighScore;
        Debug.Log("Data loaded.");
    }
    protected override void SaveDataFromGM()
    {
        caosHighScore = score;
        SaveManager.SavePlayerData(this);
        Debug.Log("Data Saved.");
    }
    protected override void GameOver()
    {
        generator.SetActive(false);
        gameOver.SetTrigger("GameOver");
        if (score > caosHighScore)
        {
            SaveDataFromGM();
            FinalScore.text = "Your new Best score is " + score.ToString() + "." +
           "\n Good Job!";
        }
        else
        {
            FinalScore.text = "Your final score is " + score.ToString() + "." +
         "\n Your Best score is " + caosHighScore.ToString() + ".";
        }
    }
}