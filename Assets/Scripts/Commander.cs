using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commander
{
    private List<Unit> myUnits;
    public List<Unit> MyUnits

    {
        get
        {
            return myUnits;
        }

        set
        {
            myUnits = value;
        }

    }
    public void AddUnit(Unit unit)
    {
        MyUnits.Add(unit);
    }

    public void SelectUnit(Unit unit)
    {
        unit.Selected = true;
    }
    public void DeSelectUnit(Unit unit)
    {
        unit.Selected = false;
    }
}
