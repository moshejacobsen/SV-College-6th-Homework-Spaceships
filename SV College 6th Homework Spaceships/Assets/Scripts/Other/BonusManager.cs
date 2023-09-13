using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusManager : MonoBehaviour
{
    [SerializeField] GameObject pickupFX;
    public float speed;
    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.score += 3;
            Instantiate(pickupFX, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
