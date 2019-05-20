using UnityEngine;

public class Enemy : MonoBehaviour
{


    public Animator animator;
    private GameObject player;
    public UnityEngine.AI.NavMeshAgent agent;
    public int res = EnemySpowner.result;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        agent.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(player.transform.position);
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
        EnemySpowner.enemCount.Remove(gameObject);
        EnemySpowner.enemyAliveCount--;
        return;
    }
}
