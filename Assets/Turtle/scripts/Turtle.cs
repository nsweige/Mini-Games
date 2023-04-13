using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour
{
    public Rigidbody2D rb;
    public LogicManager logic;

    public float moveAmount;
    public float rotationAmount;

    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.velocity = Vector2.up * moveAmount;
                if(transform.rotation.z < 0.1f)
                    transform.Rotate(0, 0, rotationAmount);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                rb.velocity = Vector2.down * moveAmount;
                if (transform.rotation.z > -0.1f)
                    transform.Rotate(0, 0, -rotationAmount);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isAlive = false;
    }
}
