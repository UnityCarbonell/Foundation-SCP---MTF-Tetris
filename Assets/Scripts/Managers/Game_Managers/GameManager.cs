using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int classicHighScore;
    public int pentaHighScore;
    public int caosHighScore;
    public static int level = 0;
    public GameEvents ge;
    public GameObject generator;
    public TextMeshProUGUI scoreTMP;
    public TextMeshProUGUI levelTMP;
    public int nextPiece;

    public GameObject pauseUIObj;
    public GameObject pauseBtnObj;

    //Game Over Screen
    public Animator gameOver;
    public TextMeshProUGUI FinalScore;

    public void OnEnable()
    {
        GameEvents.ats += PlusScore;
        GameEvents.lr += GameOver;
        GameEvents.poff += PausedOff;
    }
    public void OnDisable()
    {
        GameEvents.ats -= PlusScore;
        GameEvents.lr -= GameOver;
        GameEvents.poff -= PausedOff;
    }
    void Awake()
    {
        score = 0;
        level = 0;
        UpdateUI();
        generator.SetActive(true);
        PausedOff();
        LoadDataToGM();
    }
    void PlusScore()
    {
        score = score + 10;
        CheckLevel();
    }
    void CheckLevel()
    {
        switch (score)
        {
            case 0: 
                level = 0;
                ge.DZ();
                break;
            case 50:
                level = 1;
                ge.DO();
                break;
            case 100:
                level = 2;
                ge.DT();
                break;
            case 200: 
                level = 3;
                ge.DTH();
                break;
            case 400:
                level = 4;
                ge.DF();
                break;
        }
        UpdateUI();
    }
    void UpdateUI()
    {
        scoreTMP.text = "Score: " + score.ToString();
        switch (level)
        {
            case 0:
                levelTMP.text = "Level: SAFE";
                levelTMP.color = Color.green;
                break;
            case 1:
                levelTMP.text = "Level: EUCLID";
                levelTMP.color = Color.yellow;
                break;
            case 2:
                levelTMP.text = "Level: KETER";
                levelTMP.color = Color.red;
                break;
            case 3:
                levelTMP.text = "Level: TYAMAT";
                levelTMP.color = Color.white;
                break;
            case 4:
                levelTMP.text = "Level: APOLLEON";
                levelTMP.color = Color.black;
                break;
        }
    }
    //Pause
    public void Paused()
    {
        pauseUIObj.SetActive(true);
        pauseBtnObj.SetActive(false);
        Time.timeScale = 0f;
    }
    public void PausedOff()
    {
        pauseBtnObj.SetActive(true);
        pauseUIObj.SetActive(false);
        Time.timeScale = 1f;
    }
    /*
     Load and save data. 
     Also, the children get this methods.
    */
    protected virtual void LoadDataToGM()
    {
        PlayerData playerData = SaveManager.LoadData();
        classicHighScore = playerData.classicHighScore;
        Debug.Log("Data loaded.");
    }
    protected virtual void SaveDataFromGM()
    {
        classicHighScore = score;
        SaveManager.SavePlayerData(this);
        Debug.Log("Data Saved.");
    }
    protected virtual void GameOver()
    {
        generator.SetActive(false);
        gameOver.SetTrigger("GameOver");
        if (score > classicHighScore)
        {
            SaveDataFromGM();
            FinalScore.text = "Your new Best score is " + score.ToString() + "." +
           "\n Good Job!";
        }
        else
        {
            FinalScore.text = "Your final score is " + score.ToString() + "." +
         "\n Your Best score is " + classicHighScore.ToString() + ".";
        }
    }
}