using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public InputField userInput;
    public Animator animator;

    private string userResult;
    private int intUserRes;


    private void Start()
    {
        userResult = string.Empty;
    }

    void Update()
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

            foreach (GameObject item in EnemySpowner.enemCount)
            {
                EnemySpowner.Calc();
            }

            if (intUserRes == EnemySpowner.result)
            {
                animator.SetBool("attack", true);
                //shout add all enemys and  check for their results

                ////for (int i = 0; i < EnemySpowner.enemCount.Count; i++)
                ////{
                ////    EnemySpowner.enemCount[i].GetComponent<Enemy>().KillEnemy();
                ////    //EnemySpowner.result;
                }
            
             //   .GetComponent<Enemy>().KillEnemy();
                print("SUCCESS");
            }
            else
            {
                animator.SetBool("attack", false);
            }
        }

        //print(EnemySpowner.result + "E-Result");
        //print(userResult + "U-Res");

    }
}
