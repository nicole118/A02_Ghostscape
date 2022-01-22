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
        SceneManager.LoadScene("Level2");
       
    }
}
