using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorChanger : MonoBehaviour
{
    public TextMeshProUGUI timerRef;
    public Image backdrop;

    void Start()
    {
        ChangeColor(Color.green, 2.5f);
    }

    private Coroutine currentColorChange;
    public void ChangeColor(Color color, float duration)
    {
        if (currentColorChange != null){
            StopCoroutine(currentColorChange);
        }
        currentColorChange = StartCoroutine(ChangeColorDuration(color, duration));
    }

    IEnumerator ChangeColorDuration(Color color, float duration)
    {
        backdrop.color = color;
        yield return new WaitForSeconds(duration);
        backdrop.color = new Color32 (53,145,255,255);
        currentColorChange = null;
    }
}
