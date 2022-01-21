using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    [SerializeField] Button EasyButton, DifficultButton;

    // Start is called before the first frame update
    void Start()
    {
        EasyButton.onClick.AddListener(GoToLevel1);
        DifficultButton.onClick.AddListener(GoToLevel2);
    }

    private void GoToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    private void GoToLevel2()
    {
        SceneManager.LoadScene("Level2");

    }
}
