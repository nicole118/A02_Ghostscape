using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface ISubtractPlayerHealth
{
    int playerHealth { get; set; }
    void SubtractHealth(int amountToSubtract);
}

public class GameManager : MonoBehaviour
{
    public static GameManager ManagerInstance;
    void Awake()
    {

        if (ManagerInstance == null)
        {
            ManagerInstance = this;
        }
        else if (ManagerInstance != this)
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
