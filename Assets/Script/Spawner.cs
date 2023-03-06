using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject obstacleToGenerate;
    [SerializeField] float initialTimeToSpawn;
    [SerializeField] float repeatTimeToSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ObstacleCreate", initialTimeToSpawn, repeatTimeToSpawn);
    }

void ObstacleCreate(){
    Instantiate(obstacleToGenerate, transform.position, Quaternion.identity);
}
}
