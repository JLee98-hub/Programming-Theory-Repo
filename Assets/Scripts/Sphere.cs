using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public string shapeName { get; private set; } = "Sphere";
    public override void DisplayText()
    {
        shapeText.text = "Nice to meet you";
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
