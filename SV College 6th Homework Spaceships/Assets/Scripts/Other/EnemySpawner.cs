using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    private int enemyCount;
    public static int enemiesLeft;
    private int minX, maxX, minY, maxY;
    private int xPos, yPos;
    private void Start()
    {
        minX = -2;
        maxX = 2;
        minY = 2;
        maxY = 4;
        enemyCount = 1;
        enemiesLeft = enemyCount;
        SpawnEnemy();
    }
    private void Update()
    {
        if (enemiesLeft == 0)
        {
            for (int i = 0; i < enemyCount; i++)
            {
                SpawnEnemy();
            }
            enemiesLeft = enemyCount;
            if(enemyCount <= 5)
                enemyCount++;
        }
        
    }
    private void SpawnEnemy()
    {
        xPos = Random.Range(minX, maxX);
        yPos = Random.Range(minY, maxY);
        Instantiate(enemyPrefab, new Vector2(xPos, yPos), enemyPrefab.transform.rotation);
    }
}
