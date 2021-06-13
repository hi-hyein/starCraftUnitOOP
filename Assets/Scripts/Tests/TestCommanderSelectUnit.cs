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
            Lavar lavar = new Lavar();
            zerg.AddUnit(lavar, zerg.MyUnits);
            Unit testAddUnit = zerg.MyUnits[0];
            Assert.AreEqual(lavar, testAddUnit);
            Assert.AreEqual(false, testAddUnit.Selected);
            zerg.SelectUnit(testAddUnit);
            Assert.AreEqual(true, testAddUnit.Selected);
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
