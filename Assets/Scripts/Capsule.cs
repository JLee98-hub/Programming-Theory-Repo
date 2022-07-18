using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape // INHERITANCE
{
    public string stringName { get; private set; } = "Capsule"; // ENCAPSULATION
    public override void DisplayText() // POLYMORPHISM
    {
        shapeText.text = "How are you?";
    }

    private void OnMouseDown()
    {
        DisplayText(); // ABSTRACTION
    }
}
