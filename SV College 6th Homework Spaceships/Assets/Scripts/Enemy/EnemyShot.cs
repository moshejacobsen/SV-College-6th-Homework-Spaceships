using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject playerDeathFX;
    private void Start()
    {
        speed = 3;
    }
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(playerDeathFX, collision.transform.position, transform.rotation);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag != "Enemy")
            Destroy(gameObject);
    }
}
