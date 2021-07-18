using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestCommanderSelectUnit
    {
        [Test]
        public void TestSelectUnit()
        {
            Zerg zerg = new Zerg();
            // zerg 유닛 만들기
            zerg.AddUnit(new Lavar());
            zerg.AddUnit(new Drone());

            // 라바 한마리 가져오기
            Unit testUnit = zerg.GetUnits("LAVAR")[0];

            // 라바 한마리 선택하기
            zerg.SelectUnit(testUnit);

            // 라바 한마리 선택된 상태가 true면 성공
            Assert.AreEqual(true, testUnit.Selected);

        }

        [Test]
        public void TestSelectUnitGroup()
        {
             Zerg zerg2 = new Zerg();

            // zerg 유닛 100마리씩 만들기
            for (int i = 0; i < 100; i++)
            {
                zerg2.AddUnit(new Lavar());
                zerg2.AddUnit(new Drone());
            }

            // zerg가 가지고 있는 모든 드론, 라바 각각 변수에 가져오기
            List<Unit> testDroneUnits = zerg2.GetUnits("DRONE");
            List<Unit> testLavarUnits = zerg2.GetUnits("LAVAR");

            // 모든 드론들 선택하기
            zerg2.SelectUnit(testDroneUnits);

            // 모든 드론들의 선택된 상태가 true면 성공
            foreach (var drone in testDroneUnits)
            {
                Assert.AreEqual(true, drone.Selected);
            }

            // 모든 라바들의 선택된 상태가 false면 성공
            foreach (var labar in testLavarUnits)
            {
                Assert.AreEqual(false, labar.Selected);
            }

        }

        [Test]
        public void TestSelectUnitAll()
        {
            Zerg zerg3 = new Zerg();

            // zerg 유닛 100마리씩 만들기
            for (int i = 0; i < 100; i++)
            {
                zerg3.AddUnit(new Lavar());
                zerg3.AddUnit(new Drone());
            }

            // 모든 유닛들 선택하기
            zerg3.SelectUnit(zerg3.MyUnits);

            // 모든 유닛들의 선택된 상태가 true면 성공
            foreach (var zergUnit in zerg3.MyUnits)
            {
                Assert.AreEqual(true, zergUnit.Selected);
            }
        }
    }
}
