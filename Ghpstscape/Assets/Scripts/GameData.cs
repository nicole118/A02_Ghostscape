using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    protected GameObject player;
    static Vector3 mousePosition = new Vector3();

    private static int score = 0;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public static Vector3 MousePos
    {
        get { return MouseTarget(); }
    }
    private static Vector3 MouseTarget()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return mousePosition;
    }
}
