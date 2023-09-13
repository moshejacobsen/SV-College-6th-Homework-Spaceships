using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    [SerializeField] GameObject bonus;
    private int minX, maxX, minY, maxY;
    private int xPos, yPos;
    private void Start()
    {
        minX = -2;
        maxX = 2;
        minY = 2;
        maxY = 4;
        InvokeRepeating("SpawnBonus", 3, 7);
    }
    private void SpawnBonus()
    {
        xPos = Random.Range(minX, maxX);
        yPos = Random.Range(minY, maxY);
        Instantiate(bonus, new Vector2(xPos, yPos), transform.rotation);
    }
}
