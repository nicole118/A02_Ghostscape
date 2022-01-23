using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour
{  
    public void OnTriggerEnter2D(Collider2D PlayerWins)
    {

        if (PlayerWins.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);
            SceneManager.LoadScene("WinScene");
        }
    }
}
