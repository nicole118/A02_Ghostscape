using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Button StartPlay, SetDifficulty, Highscore, HowToPlay;



    // Start is called before the first frame update
    private void Start()
    {
        StartPlay.onClick.AddListener(Play);
        SetDifficulty.onClick.AddListener(Difficulty);
        Highscore.onClick.AddListener(ViewHighscore);
        HowToPlay.onClick.AddListener(ViewInstructions);
    }

    private void Play()
    {
        SceneManager.LoadScene("Level1");
    }

    private void Difficulty()
    {
        SceneManager.LoadScene("DifficultyLevel");
    }

    private void ViewHighscore()
    {
        SceneManager.LoadScene("ViewHighscore");
    }

    private void ViewInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

}
