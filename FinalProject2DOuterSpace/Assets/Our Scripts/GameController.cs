using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool GameOver = false;
    public float scrollSpeed = -1.5f;
    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerDied()
    { 

        GameOver = true;
    }
    }
