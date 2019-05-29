using UnityEngine;
using UnityEngine.UI;

public class DiggitLabels : MonoBehaviour
{
    private Text diggitLabel;

    void Update()
    {
        //Vector3 labelPos = Camera.main.WorldToScreenPoint(this.transform.position);
        //diggitLabel.transform.position = labelPos;
    }

    public void Initialize(DiggitLabels digitLabels)
    {
        this.diggitLabel.text = digitLabels.ToString();
    }
}
