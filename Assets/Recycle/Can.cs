using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Can : MonoBehaviour
{
    // Movement related
    public Rigidbody2D rb;
    public int moveSpeed = 10;
    Vector2 movement;

    // UI related
    public Text scoreText;

    // Status related
    public int score = 0;
    public int life = 3;
    public bool canGetHit = true;
    public bool startBlink = false;

    // Timer related
    public float timer = 0.0f;
    public float lastHit = -2.0f;
    public float protectionTime = 2.0f;

    public GameOverLogic gameOverLogic;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public GameObject lifeOff1;
    public GameObject lifeOff2;
    public GameObject lifeOff3;

    private Renderer objectRenderer;

    void Start()
    {
        gameOverLogic = GameObject.FindGameObjectWithTag("GameOver").GetComponent<GameOverLogic>();
        objectRenderer = GetComponent<Renderer>();
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if ((timer - lastHit) > protectionTime)
        {
            canGetHit = true;
        }

        if (startBlink)
        {
            StartCoroutine(BlinkObject());
            startBlink = false;
        }

        scoreText.text = score.ToString();

        if(life == 2)
        {
            life3.SetActive(false);
            lifeOff3.SetActive(true);
        }

        if (life == 1)
        {
            life2.SetActive(false);
            lifeOff2.SetActive(true);
        }

        movement.x = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + moveSpeed * movement * Time.deltaTime);

        if (life == 0)
        {
            gameOverLogic.gameOver();

            life1.SetActive(false);
            lifeOff1.SetActive(true);

            Destroy(this.gameObject);
        }
    }

    public IEnumerator BlinkObject()
    {
        float blinkTime = 2f;
        float blinkInterval = 0.1f;
        float currentTime = 0f;

        while (currentTime < blinkTime)
        {
            objectRenderer.enabled = !objectRenderer.enabled;

            yield return new WaitForSeconds(blinkInterval);

            currentTime += blinkInterval;
        }

        objectRenderer.enabled = true;
    }
}
