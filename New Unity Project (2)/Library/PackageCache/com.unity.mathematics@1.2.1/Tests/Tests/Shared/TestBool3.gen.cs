//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestBool3
    {
        [TestCompiler]
        public static void bool3_constructor()
        {
            bool3 a = new bool3(false, true, false);
            TestUtils.AreEqual(false, a.x);
            TestUtils.AreEqual(true, a.y);
            TestUtils.AreEqual(false, a.z);
        }

        [TestCompiler]
        public static void bool3_scalar_constructor()
        {
            bool3 a = new bool3(true);
            TestUtils.AreEqual(true, a.x);
            TestUtils.AreEqual(true, a.y);
            TestUtils.AreEqual(true, a.z);
        }

        [TestCompiler]
        public static void bool3_static_constructor()
        {
            bool3 a = bool3(false, true, false);
            TestUtils.AreEqual(false, a.x);
            TestUtils.AreEqual(true, a.y);
            TestUtils.AreEqual(false, a.z);
        }

        [TestCompiler]
        public static void bool3_static_scalar_constructor()
        {
            bool3 a = bool3(true);
            TestUtils.AreEqual(true, a.x);
            TestUtils.AreEqual(true, a.y);
            TestUtils.AreEqual(true, a.z);
        }

        [TestCompiler]
        public static void bool3_operator_equal_wide_wide()
        {
            bool3 a0 = bool3(true, false, true);
            bool3 b0 = bool3(true, false, false);
            bool3 r0 = bool3(true, true, false);
            TestUtils.AreEqual(r0, a0 == b0);

            bool3 a1 = bool3(false, false, true);
            bool3 b1 = bool3(false, true, false);
            bool3 r1 = bool3(true, false, false);
            TestUtils.AreEqual(r1, a1 == b1);

            bool3 a2 = bool3(false, false, true);
            bool3 b2 = bool3(false, true, false);
            bool3 r2 = bool3(true, false, false);
            TestUtils.AreEqual(r2, a2 == b2);

            bool3 a3 = bool3(false, true, false);
            bool3 b3 = bool3(false, false, false);
            bool3 r3 = bool3(true, false, true);
            TestUtils.AreEqual(r3, a3 == b3);
        }

        [TestCompiler]
        public static void bool3_operator_equal_wide_scalar()
        {
            bool3 a0 = bool3(false, true, false);
            bool b0 = (true);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(r0, a0 == b0);

            bool3 a1 = bool3(false, false, true);
            bool b1 = (false);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(r1, a1 == b1);

            bool3 a2 = bool3(false, false, true);
            bool b2 = (false);
            bool3 r2 = bool3(true, true, false);
            TestUtils.AreEqual(r2, a2 == b2);

            bool3 a3 = bool3(true, true, false);
            bool b3 = (false);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(r3, a3 == b3);
        }

        [TestCompiler]
        public static void bool3_operator_equal_scalar_wide()
        {
            bool a0 = (false);
            bool3 b0 = bool3(true, false, true);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(r0, a0 == b0);

            bool a1 = (false);
            bool3 b1 = bool3(false, true, false);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(r1, a1 == b1);

            bool a2 = (false);
            bool3 b2 = bool3(true, false, true);
            bool3 r2 = bool3(false, true, false);
            TestUtils.AreEqual(r2, a2 == b2);

            bool a3 = (true);
            bool3 b3 = bool3(false, true, false);
            bool3 r3 = bool3(false, true, false);
            TestUtils.AreEqual(r3, a3 == b3);
        }

        [TestCompiler]
        public static void bool3_operator_not_equal_wide_wide()
        {
            bool3 a0 = bool3(true, true, true);
            bool3 b0 = bool3(true, false, false);
            bool3 r0 = bool3(false, true, true);
            TestUtils.AreEqual(r0, a0 != b0);

            bool3 a1 = bool3(false, false, true);
            bool3 b1 = bool3(false, true, false);
            bool3 r1 = bool3(false, true, true);
            TestUtils.AreEqual(r1, a1 != b1);

            bool3 a2 = bool3(false, false, false);
            bool3 b2 = bool3(false, false, false);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(r2, a2 != b2);

            bool3 a3 = bool3(false, true, true);
            bool3 b3 = bool3(true, true, true);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(r3, a3 != b3);
        }

        [TestCompiler]
        public static void bool3_operator_not_equal_wide_scalar()
        {
            bool3 a0 = bool3(false, true, false);
            bool b0 = (false);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(r0, a0 != b0);

            bool3 a1 = bool3(true, false, false);
            bool b1 = (true);
            bool3 r1 = bool3(false, true, true);
            TestUtils.AreEqual(r1, a1 != b1);

            bool3 a2 = bool3(false, false, false);
            bool b2 = (false);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(r2, a2 != b2);

            bool3 a3 = bool3(false, true, false);
            bool b3 = (false);
            bool3 r3 = bool3(false, true, false);
            TestUtils.AreEqual(r3, a3 != b3);
        }

        [TestCompiler]
        public static void bool3_operator_not_equal_scalar_wide()
        {
            bool a0 = (true);
            bool3 b0 = bool3(false, false, true);
            bool3 r0 = bool3(true, true, false);
            TestUtils.AreEqual(r0, a0 != b0);

            bool a1 = (false);
            bool3 b1 = bool3(false, false, true);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(r1, a1 != b1);

            bool a2 = (true);
            bool3 b2 = bool3(true, false, false);
            bool3 r2 = bool3(false, true, true);
            TestUtils.AreEqual(r2, a2 != b2);

            bool a3 = (false);
            bool3 b3 = bool3(false, false, true);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(r3, a3 != b3);
        }

        [TestCompiler]
        public static void bool3_operator_bitwise_and_wide_wide()
        {
            bool3 a0 = bool3(false, false, true);
            bool3 b0 = bool3(false, false, true);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(r0, a0 & b0);

            bool3 a1 = bool3(true, false, false);
            bool3 b1 = bool3(false, true, true);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(r1, a1 & b1);

            bool3 a2 = bool3(true, true, true);
            bool3 b2 = bool3(false, false, true);
            bool3 r2 = bool3(false, false, true);
            TestUtils.AreEqual(r2, a2 & b2);

            bool3 a3 = bool3(false, true, true);
            bool3 b3 = bool3(true, false, false);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(r3, a3 & b3);
        }

        [TestCompiler]
        public static void bool3_operator_bitwise_and_wide_scalar()
        {
            bool3 a0 = bool3(true, false, false);
            bool b0 = (true);
            bool3 r0 = bool3(true, false, false);
            TestUtils.AreEqual(r0, a0 & b0);

            bool3 a1 = bool3(true, false, false);
            bool b1 = (true);
            bool3 r1 = bool3(true, false, false);
            TestUtils.AreEqual(r1, a1 & b1);

            bool3 a2 = bool3(false, false, true);
            bool b2 = (false);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(r2, a2 & b2);

            bool3 a3 = bool3(true, false, false);
            bool b3 = (true);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(r3, a3 & b3);
        }

        [TestCompiler]
        public static void bool3_operator_bitwise_and_scalar_wide()
        {
            bool a0 = (false);
            bool3 b0 = bool3(false, false, true);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(r0, a0 & b0);

            bool a1 = (true);
            bool3 b1 = bool3(true, false, true);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(r1, a1 & b1);

            bool a2 = (false);
            bool3 b2 = bool3(false, false, true);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(r2, a2 & b2);

            bool a3 = (false);
            bool3 b3 = bool3(false, false, true);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(r3, a3 & b3);
        }

        [TestCompiler]
        public static void bool3_operator_bitwise_or_wide_wide()
        {
            bool3 a0 = bool3(true, true, true);
            bool3 b0 = bool3(false, false, false);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(r0, a0 | b0);

            bool3 a1 = bool3(false, true, false);
            bool3 b1 = bool3(false, true, true);
            bool3 r1 = bool3(false, true, true);
            TestUtils.AreEqual(r1, a1 | b1);

            bool3 a2 = bool3(true, true, false);
            bool3 b2 = bool3(true, false, false);
            bool3 r2 = bool3(true, true, false);
            TestUtils.AreEqual(r2, a2 | b2);

            bool3 a3 = bool3(true, true, true);
            bool3 b3 = bool3(true, false, false);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(r3, a3 | b3);
        }

        [TestCompiler]
        public static void bool3_operator_bitwise_or_wide_scalar()
        {
            bool3 a0 = bool3(true, true, false);
            bool b0 = (true);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(r0, a0 | b0);

            bool3 a1 = bool3(true, true, true);
            bool b1 = (true);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(r1, a1 | b1);

            bool3 a2 = bool3(false, false, false);
            bool b2 = (true);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(r2, a2 | b2);

            bool3 a3 = bool3(true, false, true);
            bool b3 = (false);
            bool3 r3 = bool3(true, false, true);
            TestUtils.AreEqual(r3, a3 | b3);
        }

        [TestCompiler]
        public static void bool3_operator_bitwise_or_scalar_wide()
        {
            bool a0 = (true);
            bool3 b0 = bool3(true, true, false);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(r0, a0 | b0);

            bool a1 = (false);
            bool3 b1 = bool3(true, true, true);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(r1, a1 | b1);

            bool a2 = (false);
            bool3 b2 = bool3(false, true, true);
            bool3 r2 = bool3(false, true, true);
            TestUtils.AreEqual(r2, a2 | b2);

            bool a3 = (false);
            bool3 b3 = bool3(true, true, false);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(r3, a3 | b3);
        }

        [TestCompiler]
        public static void bool3_operator_bitwise_xor_wide_wide()
        {
            bool3 a0 = bool3(true, false, false);
            bool3 b0 = bool3(true, true, false);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(r0, a0 ^ b0);

            bool3 a1 = bool3(true, false, false);
            bool3 b1 = bool3(true, false, true);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(r1, a1 ^ b1);

            bool3 a2 = bool3(false, true, false);
            bool3 b2 = bool3(false, true, false);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(r2, a2 ^ b2);

            bool3 a3 = bool3(false, true, true);
            bool3 b3 = bool3(false, false, true);
            bool3 r3 = bool3(false, true, false);
            TestUtils.AreEqual(r3, a3 ^ b3);
        }

        [TestCompiler]
        public static void bool3_operator_bitwise_xor_wide_scalar()
        {
            bool3 a0 = bool3(false, false, true);
            bool b0 = (false);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(r0, a0 ^ b0);

            bool3 a1 = bool3(true, false, false);
            bool b1 = (false);
            bool3 r1 = bool3(true, false, false);
            TestUtils.AreEqual(r1, a1 ^ b1);

            bool3 a2 = bool3(false, false, false);
            bool b2 = (false);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(r2, a2 ^ b2);

            bool3 a3 = bool3(true, true, true);
            bool b3 = (false);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(r3, a3 ^ b3);
        }

        [TestCompiler]
        public static void bool3_operator_bitwise_xor_scalar_wide()
        {
            bool a0 = (true);
            bool3 b0 = bool3(true, false, true);
            bool3 r0 = bool3(false, true, false);
            TestUtils.AreEqual(r0, a0 ^ b0);

            bool a1 = (true);
            bool3 b1 = bool3(false, true, true);
            bool3 r1 = bool3(true, false, false);
            TestUtils.AreEqual(r1, a1 ^ b1);

            bool a2 = (false);
            bool3 b2 = bool3(false, true, true);
            bool3 r2 = bool3(false, true, true);
            TestUtils.AreEqual(r2, a2 ^ b2);

            bool a3 = (false);
            bool3 b3 = bool3(false, true, false);
            bool3 r3 = bool3(false, true, false);
            TestUtils.AreEqual(r3, a3 ^ b3);
        }

        [TestCompiler]
        public static void bool3_operator_logical_not()
        {
            bool3 a0 = bool3(true, true, false);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(r0, !a0);

            bool3 a1 = bool3(false, false, true);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(r1, !a1);

            bool3 a2 = bool3(false, false, false);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(r2, !a2);

            bool3 a3 = bool3(false, true, true);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(r3, !a3);
        }


    }
}
