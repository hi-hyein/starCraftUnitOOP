using System;

public class main {
	public static void Main() {
		Zerg player1 = new Zerg();
		player1.CreateUnit();
		Console.WriteLine(player1.myUnits.testName);
	}
}