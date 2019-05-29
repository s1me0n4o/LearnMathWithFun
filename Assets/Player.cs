using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public InputField userInput;
    public Animator animator;

    private string userResult;
    private int intUserRes;

    private int enemyResult;
    public GameObject enemy;
  //  private Enemy enemySkills;

    private void Start()
    {
        userResult = string.Empty;
       // enemySkills = enemy.GetComponent<Enemy>(); 
    }

    void FixedUpdate()
    {
    //    if (userInput == null)
    //    {
    //        return;
    //    }

        //if (userResult == null)
        //{
        //    return;
        //}

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("enter"))
        {
            userResult = userInput.text;
        }

        if (int.TryParse(userResult, out intUserRes))
        {
            intUserRes = int.Parse(userResult);

            foreach (GameObject enem in Enemy.enemCount)
            {

                Enemy enemyCom = enem.GetComponent<Enemy>();

                print(enemyCom.result + "PC");
                if (intUserRes == enemyCom.result)
                {
                    animator.SetBool("attack", true);
                   // print("SUCCESS");
                }
                else
                {
                    animator.SetBool("attack", false);
                   // print("Not Correct");
                }
            }
        }
    }
}
