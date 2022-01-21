using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitRestartGame : MonoBehaviour
{
    [SerializeField] Button ExitButton, RestartButton;
    // Start is called before the first frame update
    private void Start()
    {
        ExitButton.onClick.AddListener(ExitGame);
        RestartButton.onClick.AddListener(RestartGame);
    }

    private void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
        Application.OpenURL(webplayerQuitURL);
#else
        Application.Quit();
#endif
    }

    private void RestartGame()
    {
        SceneManager.LoadScene("WelcomeScreen");
    }
}
