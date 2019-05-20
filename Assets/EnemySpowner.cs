using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpowner : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject enemy;

    [Header("Calculations")]
    public int maxDigit = 10;
    public string opperator;

    [Header("UI Elements")]
    public float timeBetweenSpown = 5f;

    public static int firstDigit;
    public static int secondDigit;

    private float countDown = 2f;

    public static int result;

    public static List<GameObject> enemCount = new List<GameObject>();

    public static int enemyAliveCount;

    void Update()
    {
        if (countDown <= 0f)
        {
            if (enemCount.Count <= 2)
            {
                Instantiate(enemy, this.transform.position, Quaternion.identity);

                enemCount.Add(enemy);
                enemyAliveCount = enemCount.Count;

                GenerateRandomNumbers();

                Calc(firstDigit, secondDigit, opperator);
                print(result + " RRRRRRRRRRR");
            }

            countDown = timeBetweenSpown;
        }
        countDown -= Time.deltaTime;
        countDown = Mathf.Clamp(countDown, 0f, Mathf.Infinity);

    }

    private void GenerateRandomNumbers()
    {
        System.Random rnd = new System.Random();
        firstDigit = rnd.Next(1, maxDigit);
        secondDigit = rnd.Next(1, firstDigit);
        print(firstDigit);
        print("+");
        print(secondDigit);

    }

    public static int Calc(int a, int b, string oper)
    {
        if (oper == "+")
        {
            result = a + b;
        }
        else if (oper == "-")
        {
            result = a - b;
        }
        else if (oper == "*")
        {
            result = a * b;
        }
        else if (oper == "/")
        {
            result = a / b;
        }
        return result;
    }
    
}
