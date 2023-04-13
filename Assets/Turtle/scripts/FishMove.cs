using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    public float moveSpeed;
    public int direction;

    // Update is called once per frame
    void Update()
    {
        if (direction == 0)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }

        if (direction == 1) 
        {
        transform.position += Vector3.right * moveSpeed * Time.deltaTime; 
        }

        if (transform.position.x > 15f || transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}
