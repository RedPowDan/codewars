using System;
using Levels.Level1.DrawStairs;
using NUnit.Framework;
using Tests.Helpers;

namespace Tests.Level1.DrawStairHelperTests
{
    [TestFixture]
    public class DrawStairHelperTests
    {
        [Test]
        public void Test1()
        {
            var number = 3;
            var assert = "I\n I\n  I";
            
            var result = HelperTests<string>.Run(() => DrawStairHelper.DrawStair(number));

            Assert.True(string.Equals(result, assert));
        }
        
        [Test]
        public void Test2()
        {
            var number = 4;
            var assert = "I\n I\n  I\n   I";
            
            var result = HelperTests<string>.Run(() => DrawStairHelper.DrawStair(number));

            Assert.True(string.Equals(result, assert));
        }
        
        [Test]
        public void Test3()
        {
            var number = 0;

            Assert.Throws<ArgumentException>(
                () => HelperTests<string>.Run(() => DrawStairHelper.DrawStair(number)));
        }
        
        [Test]
        public void Test4()
        {
            var number = -12;

            Assert.Throws<ArgumentException>(
                () => HelperTests<string>.Run(() => DrawStairHelper.DrawStair(number)));
        }
        
        [Test]
        public void Test5()
        {
            var number = 12;

            Assert.Throws<ArgumentException>(
                () => HelperTests<string>.Run(() => DrawStairHelper.DrawStair(number, null)));
        }
    }
}