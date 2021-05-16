﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        public int NewTestScriptSimplePasses(int a, int b)
        {
            return a + b;
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            Assert.AreEqual(5, NewTestScriptSimplePasses(2, 3));
            // Use yield to skip a frame.
            yield return null;
        
        }
    }
}
