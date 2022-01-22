using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanvasManager : MonoBehaviour
{
    public static CanvasManager CanvasInstance;
    public static GameManager manager;
    private void Awake()
    {
        if (CanvasInstance == null)
        {
            CanvasInstance = this;
        }
        else if (CanvasInstance != this)
        {
            Destroy(this.gameObject);
        }
        SceneManager.sceneLoaded -= manager.OnSceneLoaded;
        DontDestroyOnLoad(this.gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
