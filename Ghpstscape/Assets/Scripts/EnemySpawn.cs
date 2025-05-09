using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawn : MonoBehaviour
{
    private GameObject enemy;
    private GameObject myEnemy;


    // Start is called before the first frame update
    private void Start()
    {
        enemy = Resources.Load("warrior_1") as GameObject;
        Spawner1();
        Spawner2();
        Spawner3();
    }


    private void Spawner1()
    {
        for(int i = 0; i < 15; i++)
        {
            Vector3 spawnPosition1= new Vector3(Random.Range(10f, 20.0f), Random.Range(0f, 1f), 0);
            myEnemy = Instantiate(enemy, new Vector3(spawnPosition1.x, -0.5f, 0f), Quaternion.identity) as GameObject;
        }
        
    }

    private void Spawner2()
    {
        for (int a = 0; a < 5; a++)
        {
            Vector3 Spawnposition2 = new Vector3(Random.Range(50f, 60.0f), Random.Range(0f, 1f), 0);
            myEnemy = Instantiate(enemy, new Vector3(Spawnposition2.x, -0.5f, 0f), Quaternion.identity) as GameObject;
            
        }
    }

    private void Spawner3()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string myScene = currentScene.name;

        if (myScene == "Level2")
        {

            for (int a = 0; a < 10; a++)
            {
                Vector3 Spawnposition2 = new Vector3(Random.Range(100f, 60.0f), Random.Range(0f, 1f), 0);
                myEnemy = Instantiate(enemy, new Vector3(Spawnposition2.x, -0.5f, 0f), Quaternion.identity) as GameObject;

            }
        }
    }

}
