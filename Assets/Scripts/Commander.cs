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

    public List<Unit> GetUnits(string unitName)
    {
      return MyUnits.FindAll(x => x.Name == unitName);
    }

    public void SelectUnit(Unit unit)
    {
        unit.Selected = true;
    }
    public void DeSelectUnit(Unit unit)
    {
        unit.Selected = false;
    }

    public void SelectUnit(List<Unit> units)
    {
        foreach (var unit in units)
        {
            unit.Selected = true;
        }
    }
    public void DeSelectUnit(List<Unit> units)
    {
        foreach (var unit in units)
        {
            unit.Selected = false;
        }
    }
}
