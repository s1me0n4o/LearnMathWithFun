using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public InputField userInput;
    public Animator animator;

    private string userResult;
    private int intUserRes;

    private int enemyResult;

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

            foreach (GameObject enemy in Enemy.enemCount)
            {

                if (intUserRes == Enemy.result)
                {
                    animator.SetBool("attack", true);

                    print("SUCCESS");
                }
                else
                {
                    animator.SetBool("attack", false);
                    print("Not Correct");
                }
            }
        }
    }
}
