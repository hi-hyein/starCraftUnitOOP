using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zerg : Commander
{
    private static List<Unit> myUnits;
    public static List<Unit> MyUnits

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
