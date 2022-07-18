using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    public string stringName { get; private set; } = "Capsule";
    public override void DisplayText()
    {
        shapeText.text = "How are you?";
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
