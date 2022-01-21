using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClicked : MonoBehaviour
{
    [SerializeField] Button OkButton;

    // Start is called before the first frame update
    void Start()
    {
        OkButton.onClick.AddListener(LetsContinue);
    }

    private void LetsContinue()
    {
        SceneManager.LoadScene("WelcomeScreen");

    }
}
