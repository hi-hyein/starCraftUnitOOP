using System;

public abstract class Unit
{
    abstract void Move();
}

public class Drone : Unit
{
    public override void Move() {
        Console.WriteLine("드론이 이동한다");
	}
}