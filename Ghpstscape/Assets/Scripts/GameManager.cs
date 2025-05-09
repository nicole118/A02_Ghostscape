using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

interface ISubtractPlayerHealth
{
    int playerHealth { get; set; }
    void SubtractHealth(int amountToSubtract);
}

public class GameManager : MonoBehaviour
{
    public Text ScoreText;
    public Text HighScoreText;

    [SerializeField] GameObject playerPrefab;

    public static GameManager ManagerInstance;
    void Awake()
    {
        if (ManagerInstance == null)
        {
            ManagerInstance = this;
        }
        else if (ManagerInstance != this)
        {
            Destroy(this.gameObject);
        }
        SceneManager.sceneLoaded += OnSceneLoaded;
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        GameData.Score = 0;
        GameData.Highscore = 0;
        GameData.Hearts = 3;
        GameData.Highscore = PlayerPrefs.GetInt("highscore", 0);
        ScoreText.text = "Score: " + GameData.Score.ToString();
        
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "LoseScene" || scene.name == "WinScene")
        {
            if (GameData.Score > GameData.Highscore)
            {
                GameData.Highscore = GameData.Score;
            }

            GetComponent<SavingLoading>().SaveMyData();

            Text score = GameObject.Find("Score").GetComponent<Text>();
            score.text = "Score: " + GameData.Score.ToString();

            Text hScore = GameObject.Find("Highscore").GetComponent<Text>();
            hScore.text = "High Score:" + GameData.Highscore.ToString();
        }

        if(scene.name == "ViewHighscore" ||  scene.name == "WinSceneLevel2")
        {
            if (GameData.Score > GameData.Highscore)
            {
                GameData.Highscore = GameData.Score;
            }
            GetComponent<SavingLoading>().SaveMyData();

            Text score = GameObject.Find("Score").GetComponent<Text>();
            score.text = "Score: " + GameData.Score.ToString();
            Text hScore = GameObject.Find("Highscore").GetComponent<Text>();
            hScore.text = "High Score:" + GameData.Highscore.ToString();
        }
    }

    public void AddPoints()
    {
        GameData.Score += 10;
        ScoreText.text = "Score: " + GameData.Score.ToString();
        if(GameData.Highscore < GameData.Score)
        {
            PlayerPrefs.SetInt("highscore", GameData.Score);
            GetComponent<SavingLoading>().SaveMyData();
        }

    }
}
