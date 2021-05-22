using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit
{
    bool selected = false;

    public void SelectMyself()
    {
        selected = true;
    }
}