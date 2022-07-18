using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI shapeText;
    public virtual void DisplayText()
    {
        shapeText.text = "Hello";
    }
}
