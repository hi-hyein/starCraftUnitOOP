using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestCommander
    {
        [Test]
        public void TestSelectUnit1()
        {
            Commander zerg = new Zerg();
            var lavar = new Lavar();
            var myUnits = Zerg.MyUnits;
            Assert.AreEqual(1, myUnits.Count);
        }

        //[Test]
        //public void TestSelectUnit2()
        //{
        //    var commander = new Commander();
        //    var lavar = new Lavar();
        //    var selectUnit = commander.SelectUnit();
        //    Assert.AreEqual(lavar.GetType(), selectUnit.GetType());
        //}
    }
}
