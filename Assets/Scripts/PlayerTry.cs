using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerTry : MonoBehaviour
{
    private Vector2 targetPos;
    private Shake shake;
    public float Yincrement;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;

    public GameObject effect;
    public Text healthDisplay;

    public GameObject gameOver;
    public GameObject popSound;
    public Animator camAnim;

    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("Screenshake").GetComponent<Shake>();
    }

    public void Update()
    {
        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
    public void ArrowUpPressed()
        {
            if (transform.position.y < maxHeight)
            {
                Instantiate(popSound, transform.position, Quaternion.identity);
                camAnim.SetTrigger("shake");
                Instantiate(effect, transform.position, Quaternion.identity);
                targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = targetPos;
            }
    }


    public void ArrowDownPressed()
        {
            if (transform.position.y > minHeight)
            {
                Instantiate(popSound, transform.position, Quaternion.identity);
                camAnim.SetTrigger("shake");
                Instantiate(effect, transform.position, Quaternion.identity);
                targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
                transform.position = targetPos;
            }
        }
    
}

