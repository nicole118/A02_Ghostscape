using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToLevel2 : MonoBehaviour
{
    [SerializeField] Button Level2Button;

    
    // Start is called before the first frame update
    private void Start()
    {
        
        Level2Button.onClick.AddListener(ToLevel2);

    }

    private void ToLevel2()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        Debug.Log(sceneName);
        if (sceneName == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }

        if(sceneName == "Level2")
        {
            SceneManager.LoadScene("ViewHighscore");
        }

    }
}
