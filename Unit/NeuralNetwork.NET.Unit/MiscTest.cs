﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeuralNetworkNET.Helpers;

namespace NeuralNetworkNET.Unit
{
    /// <summary>
    /// Test class for various helper methods and extensions
    /// </summary>
    [TestClass]
    [TestCategory(nameof(MiscTest))]
    public class MiscTest
    {
        [TestMethod]
        public void Partition()
        {
            IEnumerable<int> items = Enumerable.Range(0, 25);
            StringBuilder builder = new StringBuilder();
            foreach (var chunk in items.Partition(7))
                builder.Append($"{chunk.Aggregate(String.Empty, (s, i) => $"{s} {i}")}\n");
            String result = builder.ToString();
            Assert.IsTrue(result.Equals(" 0 1 2 3 4 5 6\n 7 8 9 10 11 12 13\n 14 15 16 17 18 19 20\n 21 22 23 24\n"));
        }
    }
}
