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
            // 같은 타입의 유닛들만 선택
        }

        [Test]
        public void TestSelectUnitAll()
        {
            // 모든 유닛 선택
        }

    }
}
