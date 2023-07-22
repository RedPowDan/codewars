using Levels.Level1.DrawStairs;
using Levels.Level3.DiffArray;
using NUnit.Framework;
using Tests.Helpers;

namespace Tests.Level3.DiffArray
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void Test1()
        {
            HelperTests<bool>.Run(() =>
            {
                Assert.AreEqual(new[] {2},       Kata<int>.ArrayDiff(new[] {1, 2},    new[] {1}));
                Assert.AreEqual(new[] {2, 2},    Kata<int>.ArrayDiff(new[] {1, 2, 2}, new[] {1}));
                Assert.AreEqual(new[] {1},       Kata<int>.ArrayDiff(new[] {1, 2, 2}, new[] {2}));
                Assert.AreEqual(new[] {1, 2, 2}, Kata<int>.ArrayDiff(new[] {1, 2, 2}, new int[] {}));
                Assert.AreEqual(new int[] {},    Kata<int>.ArrayDiff(new int[] {},        new[] {1, 2}));
                Assert.AreEqual(new[] {3}, Kata<int>.ArrayDiff(new[] {1, 2, 3}, new[] {1, 2}));
                return true;
            });
        }
    }
}