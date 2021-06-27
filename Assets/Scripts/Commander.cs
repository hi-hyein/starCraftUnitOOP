using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commander
{
    public void AddUnit(Unit unit, List<Unit> myUnits)
    {
        myUnits.Add(unit);
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
