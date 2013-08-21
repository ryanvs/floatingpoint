using System;
using floatingpoint;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testfloatingpoint
{
    [TestClass]
    public class FloatInfoTest
    {
        [TestMethod]
        public void SetInt32WithValueOfZeroMatches()
        {
            FloatInfo fi = new FloatInfo();
            fi.SetInt32(0);
            // Main values
            Assert.AreEqual(0, fi.IntValue, "IntValue does not match");
            Assert.AreEqual(0.0, fi.FloatValue, "FloatValue does not match");
            // Component value: sign, exponent, mantissa
            Assert.AreEqual(false, fi.Sign, "Sign does not match");
            Assert.AreEqual(0, fi.Exponent, "Exponent does not match");
            Assert.AreEqual(-127, fi.ExponentBiased, "ExponentBiased does not match");
            Assert.AreEqual(0, fi.Significand, "Significand does not match");
            // String values
            Assert.AreEqual("0", fi.FloatString, "FloatString does not match");
            Assert.AreEqual("0", fi.IntString, "IntString does not match");
            Assert.AreEqual("00000000", fi.HexString, "HexString does not match");
            // Bit values
            for (int ii = 0; ii < FloatInfo.TotalBits; ii++)
            {
                Assert.AreEqual(false, fi.Bits[ii], "Bits[" + ii.ToString() + "] does not match");
            }
        }

        [TestMethod]
        public void SetFloatWithValueOfOneMatches()
        {
            FloatInfo fi = new FloatInfo();
            fi.SetFloat(1.0f);
            // Main values
            Assert.AreEqual(1065353216, fi.IntValue, "IntValue does not match");
            Assert.AreEqual(1.0f, fi.FloatValue, "FloatValue does not match");
            // Component value: sign, exponent, mantissa
            Assert.AreEqual(false, fi.IsSmallNumber, "IsSmallNumber does not match");
            Assert.AreEqual(false, fi.Sign, "Sign does not match");
            Assert.AreEqual(127, fi.Exponent, "Exponent does not match");
            Assert.AreEqual(0, fi.ExponentBiased, "ExponentBiased does not match");
            Assert.AreEqual(0, fi.Significand, "Significand does not match");
            // String values
            Assert.AreEqual("1", fi.FloatString, "FloatString does not match");
            Assert.AreEqual("1065353216", fi.IntString, "IntString does not match");
            Assert.AreEqual("3F800000", fi.HexString, "HexString does not match");
            // Bit values
        }
    }
}
