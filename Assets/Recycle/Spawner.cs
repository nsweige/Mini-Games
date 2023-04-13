using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> waste;
    public List<GameObject> spawnPos;

    public int randomPos;
    public int randomWaste;

    //Timer Related
    public float timer = 0.0f;
    public float lSpawn = 0.0f;
    public float sTime = 1.0f;

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer - lSpawn > sTime)
        {
            lSpawn = timer;
            randomPos = Random.Range(0, 8);
            randomWaste = Random.Range(0, 4);

            Instantiate(waste[randomWaste], spawnPos[randomPos].transform.position, spawnPos[randomPos].transform.rotation);
        }

    }
}
