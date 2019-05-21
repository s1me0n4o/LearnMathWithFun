using System;
using UnityEngine;

public class EnemySpowner : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject enemy;

    [Header("UI Elements")]
    public float timeBetweenSpown = 5f;

    private float countDown = 2f;

    public static int enemyAliveCount;

    public int MaxDig = 10;

    void Update()
    {
        if (countDown <= 0f)
        {
            if (Enemy.enemCount.Count <= 2)
            {
                Instantiate(enemy, this.transform.position, Quaternion.identity);

                Enemy.GenerateRandomNumbers(MaxDig);
                
                Enemy.enemCount.Add(enemy);
                enemyAliveCount = Enemy.enemCount.Count;

            }

            countDown = timeBetweenSpown;
        }
        countDown -= Time.deltaTime;
        countDown = Mathf.Clamp(countDown, 0f, Mathf.Infinity);

    }

}
