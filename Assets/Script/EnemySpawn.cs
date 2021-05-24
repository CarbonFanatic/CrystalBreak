using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {


    public GameObject[] groups;
    public Transform[] spawns;
    public float SpawnTime = 5f;
    public float SpeedIncrease = 1f;

    public void spawnNext()
    {
        int r = Random.Range(0, spawns.Length);
        // Random Index
        int i = Random.Range(0, groups.Length);

        // Spawn Group at current Position
        Instantiate(groups[i],
                    spawns[r].position,
                    Quaternion.identity);
    }

    private void Start()
    {
        // Spawn initial Group
        InvokeRepeating("spawnNext", SpawnTime, SpawnTime);

        //Increases spawn rate over time
        InvokeRepeating("increaseSpawn", 30, 30);
    }

    void increaseSpawn()
    {
        
        CancelInvoke("spawnNext");

        //This will limit the spawn speed to a min of 1.
        if ((SpawnTime - SpeedIncrease) < 1)
        {
              SpawnTime = 1f;
        }
        else
        {
            SpawnTime = SpawnTime - SpeedIncrease;
        }

        //Restart spawn with new repeat time.
        
        InvokeRepeating("spawnNext", 0, SpawnTime);
    }
}
