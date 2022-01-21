using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour, ISubtractPlayerHealth
{
    public GameObject[] hearts;
    public int playerHealth { get; set; }
    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = hearts.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead == true)
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene("LoseScene");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SubtractHealth(1);
        }
    }

    public void SubtractHealth(int amountToSubtract)
    {
        if (playerHealth >= 1)
        {
            playerHealth -= amountToSubtract;
            Destroy(hearts[playerHealth].gameObject);
            if (playerHealth < 1)
            {
                isDead = true;
            }
        }
    }

    

}
