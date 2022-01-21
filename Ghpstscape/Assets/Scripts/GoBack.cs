using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    [SerializeField] Button GoBackButton;

    // Start is called before the first frame update
    void Start()
    {
        GoBackButton.onClick.AddListener(GoToWelcomeScreen);
    }

    private void GoToWelcomeScreen()
    {
        SceneManager.LoadScene("WelcomeScreen");
    }
}
