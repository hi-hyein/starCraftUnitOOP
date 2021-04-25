using System;
using System.Collections.Generic;

public class Commander
{		
	
	public void CreateUnit()
	{
		Console.WriteLine("유닛생성");
	}
	
	public void SelectUnit()
	{
		Console.WriteLine("유닛선택");
	}
	
	public void SetPosition()
	{
		Console.WriteLine("유닛좌표선택");
	}
	
	public void MoveUnit()
	{
		Console.WriteLine("유닛이동");
	}
}

public class MyUnits
{
	public string testName = "test";
	public List<Unit> myUnitList;
	
	public void ValidationUnit()
	{
		Console.WriteLine("유닛 유효성 검사");
	}
}

public class Zerg : Commander {
	// 저그의 유닛 리스트
	public enum Units {
		labar,
		drone
	};
	
	// 내가 갖고 있는 유닛 정보
	public MyUnits myUnits = new MyUnits();
}
