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

    private string name;
    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

}