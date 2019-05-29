using System.Collections;
using UnityEngine;


public class EnemySpowner : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject enemy;

    [Header("UI Elements")]
    public float timeBetweenSpown = 5f;

    public static float countDown = 2f;

    public static int enemyAliveCount;

    public int MaxDig = 10;

    private GameObject enemySkills;

    public DiggitLabels digitLabels;
    
    void Update()
    {
        countDown = Mathf.Clamp(countDown, 0f, Mathf.Infinity);
        countDown -= Time.deltaTime;

        if (countDown <= 0f)
        {
            if (Enemy.enemCount.Count <= 2)
            {
                SpownEnemy();
            }

            countDown = timeBetweenSpown;
        }

    }

    private void SpownEnemy()
    {
        enemySkills = Instantiate(enemy, this.transform.position, Quaternion.identity);
        enemySkills.GetComponent<Enemy>().GenerateRandomNumbers(MaxDig);
       //ToDo add visual references to the diggits and opperator above the enemy

        // enemySkills.GetComponent<DiggitLabels>().Initialize(digitLabels);


        Enemy.enemCount.Add(enemySkills);
        enemyAliveCount = Enemy.enemCount.Count;
    }

    IEnumerator WaitAndInstatiate()
    {
        yield return new WaitForSeconds(0.5f);
        
    }

}
