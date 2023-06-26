using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tree;
    private float timeBtwSpawn;
    public float StartTimeBtwSpawn;
    private Vector3 SpawnPos;
    float xPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //xPos = Random.Range(-1.8f, 8.97f);
        //SpawnPos = new Vector3(xPos, transform.position.y, transform.position.z);
        if (timeBtwSpawn <= 0)
        {
            Instantiate(tree, transform.position, transform.rotation);
            timeBtwSpawn = StartTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
