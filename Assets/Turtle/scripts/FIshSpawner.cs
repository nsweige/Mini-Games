using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIshSpawner : MonoBehaviour
{
    public GameObject fish;
    public List<GameObject> spawnPos;

    public int randomPos;

    //Timer Related
    public float timer = 0.0f;
    public float lSpawn = 0.0f;
    public float sTime = 3.0f;

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer - lSpawn > sTime)
        {
            lSpawn = timer;
            randomPos = Random.Range(0, 5);

            Instantiate(fish, spawnPos[randomPos].transform.position, spawnPos[randomPos].transform.rotation);

            sTime = Random.Range(2.5f, 3.5f);
        }

    }
}
