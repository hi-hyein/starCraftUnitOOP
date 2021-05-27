using System;

public abstract class Unit
{
    abstract void Move();
}

public class Lavar : Unit
{
    public override void Move() {
        Console.WriteLine("라바가 이동한다");
	}
}

public class Drone : Unit
{
    public override void Move() {
        Console.WriteLine("드론이 이동한다");
	}
}