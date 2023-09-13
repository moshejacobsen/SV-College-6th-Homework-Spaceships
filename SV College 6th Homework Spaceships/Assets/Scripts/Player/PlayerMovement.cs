using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject shot;
    [SerializeField] GameObject shotSpawn;
    [SerializeField] float moveSpeed = 10;
    private int horDir = 0;
    private int verDir = 0;
    private void Start()
    {
        moveSpeed = 3;
    }
    private void Update()
    {
        if (transform.position.x > 2.5f)
            transform.position = new Vector2(2.5f, transform.position.y);
        else if (transform.position.x < -2.5f)
            transform.position = new Vector2(-2.5f, transform.position.y);
        if (transform.position.y > 4.6f)
            transform.position = new Vector2(transform.position.x, 4.6f);
        else if (transform.position.y < -4.6f)
            transform.position = new Vector2(transform.position.x, -4.6f);
        transform.Translate(new Vector2(1 * horDir * moveSpeed * Time.deltaTime, 1 * verDir * moveSpeed * Time.deltaTime));
        GetComponent<Animator>().SetBool("isShooting", false);
    }
    public void Movement(string str)
    {
        if (str == "Right")
        {
            horDir = 1;
            verDir = 0;
        }
        else if (str == "Left")
        {
            horDir = -1;
            verDir = 0;
        }
        else if (str == "Up")
        {
            horDir = 0;
            verDir = 1;
        }
        else if (str == "Down")
        {
            horDir = 0;
            verDir = -1;
        }
    }
    public void StopMove()
    {
        horDir = 0;
        verDir = 0;
    }
    public void Shoot()
    {
        GetComponent<Animator>().SetBool("isShooting", true);
        Instantiate(shot, shotSpawn.transform.position, shot.transform.rotation);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);

        }
    }

}
