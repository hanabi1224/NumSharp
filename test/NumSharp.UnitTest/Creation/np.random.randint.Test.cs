﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumSharp;
using NumSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumSharp.UnitTest.Creation
{
    [TestClass]
    public class NdArrayRandomRandIntTest
    {
        [TestMethod]
        public void randint()
        {
            var a = new NumPyRandom().randint(low: 0, high: 10, shape: new Shape(5, 5));
            Assert.IsTrue(a.Storage.GetData<int>().Count(x => x < 10) == 25);
        }
    }
}
