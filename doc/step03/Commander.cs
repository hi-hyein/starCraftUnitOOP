using System;
using System.Collections.Generic;

public class Commander
{	
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

public class Zerg : Commander {	
	private int mineral; // 미네랄
	private int gas;// 가스
	private int nowPopulationCount;	// 현재 인구수
	private int maxPopulationCount; // 최대 인구수
	private List<Unit> myUnits; // 유닛리스트

	public Zerg (int mineral, int gas, int nowPopulationCount, int maxPopulationCount) {
		this.mineral = mineral;
		this.gas = gas;
		this.nowPopulationCount = nowPopulationCount;
		this.maxPopulationCount = maxPopulationCount;
		this.myUnits = new List<Unit>();
	}

	public void 해처리생성()
	{
		if(mineral < 300) {
			Console.WriteLine("미네랄 부족, 생성 실패");
			return;
		}

		// 보유 미네랄이 300미만이면 생성 불가능
		// 생성시 300미네랄 소모
		Console.WriteLine("해처리 생성 성공!");
	}
}
