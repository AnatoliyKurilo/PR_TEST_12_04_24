using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PR_TEST_12_04_24;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a=1;
            double b=1;
            double c=1;
            string Expected = "Квадратное уравнение не имеет корней";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR_TEST_12_04_24.Program.Ur(a, b, c);

                var result = Program.Ur(a, b, c); //sw.ToString().Trim();

                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            double a = 1;
            double b = 2;
            double c = 0;
            string Expected = "x1 = 0; x2 = -2";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR_TEST_12_04_24.Program.Ur(a, b, c);

                //var result = sw.ToString().Trim();
                var result = Program.Ur(a, b, c);
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]

        public void TestMethod3()
        {
            double a = 1;
            double b = 2;
            double c = 1;
            string Expected = "x1 = -1; x2 = -1";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR_TEST_12_04_24.Program.Ur(a, b, c);

                //var result = sw.ToString().Trim();
                var result = Program.Ur(a, b, c);
                Assert.AreEqual(Expected, result);
            }
        }

    }
}
