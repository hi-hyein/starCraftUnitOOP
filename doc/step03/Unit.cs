using System;

public abstract class Unit
{
    public void Move()
    {
        Console.WriteLine("이동이동");
    }
}

public class Drone : Unit
{
}