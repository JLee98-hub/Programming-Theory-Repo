using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape // INHERITANCE
{
    public string shapeName { get; private set; } = "Cube"; // ENCAPSULATION
    private void OnMouseDown()
    {
        DisplayText(); // ABSTRACTION
    }

    
}
