using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorChanger : MonoBehaviour
{
    public TextMeshProUGUI timerRef;
    public Image backdrop;
    void Awake()
    {
        backdrop.color = new Color32 (53,145,255,255);
    }

    public void ChangeColor(Color color)
    {
        backdrop.color = color;
    }
}
