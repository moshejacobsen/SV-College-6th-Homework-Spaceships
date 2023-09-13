using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] GameObject shot;
    [SerializeField] GameObject shot1Spawn;
    [SerializeField] GameObject shot2Spawn;
    [SerializeField] GameObject playerDeathFX;
    public float timer = 3;
    public float moveSpeed = 1;
    private void Start()
    {
        InvokeRepeating("Shoot", 1.0f, timer);
        moveSpeed = Random.Range(0.5f, 1.5f);
    }
    private void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }
    private void Shoot()
    {
        Instantiate(shot, shot1Spawn.transform.position, shot1Spawn.transform.rotation);
        Instantiate(shot, shot2Spawn.transform.position, shot2Spawn.transform.rotation);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(playerDeathFX, collision.transform.position, transform.rotation);
            Destroy(collision.gameObject);
        }
    }
}
