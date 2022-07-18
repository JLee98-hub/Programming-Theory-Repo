using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public string shapeName { get; private set; } = "Cube";
    private void OnMouseDown()
    {
        DisplayText();
    }

    
}
