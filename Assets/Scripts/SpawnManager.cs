using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;

    // private PlayerController playerControllerScript;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

    }

    // Update is called once per frame
    void Update()
    {

<<<<<<< Updated upstream
    }
=======
   
>>>>>>> Stashed changes


    void SpawnRandomObstacle()
    { //spawn from top
        int obstacleIndex = Random.Range(0, obstaclePrefab.Length);

        Instantiate(obstaclePrefab[obstacleIndex], spawnPos, obstaclePrefab[obstacleIndex].transform.rotation);
    }
}
