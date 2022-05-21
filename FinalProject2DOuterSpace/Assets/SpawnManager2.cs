using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public bool GameOver = true;
    public GameObject[] packetPrefab;
    public int PacketIndex;
    private float spawnrangeY = 6;
    private float spawnInterval = 20.0f;
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
        int PacketIndex = Random.Range(0, packetPrefab.Length);
        Vector2 spawnPos = new Vector2(37, Random.Range(-spawnrangeY, spawnrangeY));
        Instantiate(packetPrefab[PacketIndex], spawnPos, packetPrefab[PacketIndex].transform.rotation);
    }
}
