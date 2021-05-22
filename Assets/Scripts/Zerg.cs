using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zerg : Commander
{
    private List<Unit> myUnits;
    public List<Unit> MyUnits

    {
        get
        {
            return myUnits;
        }

        set {
            myUnits = value;
        }
    }

    public Zerg()
	{
		MyUnits = new List<Unit>();
	}
}
