using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool GameOver = true;
    public GameObject[] rockPrefabs;
    public int rockIndex;
    private float spawnrangeY = 6;
    private float spawnInterval = 1.5f;
    private float startDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomRock", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomRock()
    {
        int rockIndex = Random.Range(0, rockPrefabs.Length);
        Vector2 spawnPos = new Vector2(37, Random.Range(-spawnrangeY, spawnrangeY));
        Instantiate(rockPrefabs[rockIndex], spawnPos, rockPrefabs[rockIndex].transform.rotation);
    }
    public void PlayerDied()
    {

        

        GameOver = true;
    }
}

