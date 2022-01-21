using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    protected GameObject player;

    private static int _score;
    private static int _hearts;
    private static int _topScore;

    public static int Score
    {
        get { return _score; }
        set { _score = value; }
    }

    public static int Hearts
    {
        get { return _hearts; }
        set { _hearts = value; }
    }

    public static int Highscore
    {
        get { return _topScore; }
        set { _topScore = value; }
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
}
