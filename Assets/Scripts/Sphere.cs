using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
    public string shapeName { get; private set; } = "Sphere"; // ENCAPSULATION
    public override void DisplayText() // POLYMORPHISM
    {
        shapeText.text = "Nice to meet you";
    }

    private void OnMouseDown()
    {
        DisplayText(); // ABSTRACTION
    }
}
