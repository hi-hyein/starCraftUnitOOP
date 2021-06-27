using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit
{
    private bool selected = false;
    public bool Selected
    {
        get
        {
            return selected;
        }

        set
        {
            selected = value;
        }
    }

}