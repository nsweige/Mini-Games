using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacles;

    public float spawnRate = 3f;
    private float timer = 0f;
    public float heightOffset = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if( timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            SpawnObstacle();
            timer = 0;
        }
    }

    void SpawnObstacle()
    {
        float LowestPoint = transform.position.y - heightOffset;
        float HighestPoint = transform.position.y + heightOffset;

        Instantiate(obstacles, new Vector3(transform.position.x, Random.Range(LowestPoint, HighestPoint), 0), transform.rotation);
    }
}
