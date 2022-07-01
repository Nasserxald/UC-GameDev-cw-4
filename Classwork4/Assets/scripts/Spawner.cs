using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnObject;

    void Spawn()
    {
        int newPosition = Random.Range(-1, 2);
        Vector3 vposition = transform.position;
        vposition.x = vposition.x + 5 * newPosition;

        GameObject newSpawn = Instantiate(spawnObject);
        newSpawn.transform.position = vposition;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
