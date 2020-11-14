﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;

    public GameObject effect;
    private Animator camAnim;

    public GameObject explosionSound;

    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(explosionSound, transform.position, Quaternion.identity);
            camAnim.SetTrigger("shakeObstacle");
            Instantiate(effect, transform.position, Quaternion.identity);

            other.GetComponent<PlayerTry>().health -= damage;
            Debug.Log(other.GetComponent<PlayerTry>().health);
            Destroy(gameObject);
        }
    }
}
