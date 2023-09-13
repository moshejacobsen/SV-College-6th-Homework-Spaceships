using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject enemyDeathFX;
    private void Start()
    {
        speed = 5;
    }
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            EnemySpawner.enemiesLeft--;
            Instantiate(enemyDeathFX, collision.transform.position, transform.rotation);
            Destroy(collision.gameObject);
            ScoreManager.score++;
        }
        if (collision.gameObject.tag != "Player")
            Destroy(gameObject);
    }
}
