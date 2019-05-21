using UnityEngine;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{


    public Animator animator;
    private GameObject player;
    public UnityEngine.AI.NavMeshAgent agent;

    [Header("Calculations")]
    public int maxDigit = 10;

    public static int firstDigit;
    public static int secondDigit;
    public string opper = "+";
    public static string opperator;
    public static int result;
    public static List<GameObject> enemCount = new List<GameObject>();

    private void Awake()
    {
        opperator = opper;
    }

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        agent.GetComponent<UnityEngine.AI.NavMeshAgent>();
        
    }

    private void Update()
    {
        agent.SetDestination(player.transform.position);
    }

    public static void GenerateRandomNumbers(int maxNum)
    {
        System.Random rnd = new System.Random();
        firstDigit = rnd.Next(1, maxNum);
        secondDigit = rnd.Next(1, firstDigit);


        result = Calc(firstDigit, secondDigit, opperator);
        print(result);
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

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("walk", false);
        animator.SetTrigger("attack01");

        KillEnemy();

        print("GameOver");

    }

    public void KillEnemy()
    {
        animator.SetBool("walk", false);
        animator.SetTrigger("attack01");
        Destroy(gameObject, 2);
        enemCount.Remove(gameObject);
        EnemySpowner.enemyAliveCount--;
        return;
    }
}
