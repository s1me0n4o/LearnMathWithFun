using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public Text timer;
    private float timerFloat;

    void Update()
    {
        timerFloat = EnemySpowner.countDown;
        timer.text = timerFloat.ToString("F0");
    }
}
