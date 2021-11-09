// 2021-11-05, Darius Patiejunas
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class Class1
    {
        [Test]
        public static void TestIf4IsEven()
        {
            int leftover = 4 % 2;
            Assert.AreEqual(0,leftover, "4 is not Even");
        }

        [Test]
        public static void TestNowIs19() 
        {
            DateTime CurrentTime = DateTime.Now;
            Assert.IsFalse(CurrentTime.Hour.Equals(19), "dabar ne 19 valanda");

        }

        [Test] 

        public static void TestArDalijasiIs3() 
        {
            int dalmuo = 9 % 3;
            Assert.AreEqual(0, dalmuo, "9 dalina is 3");

        }

        [Test]

        public static void TestIfTodayIsMonday() 
        {
            DayOfWeek Today = DayOfWeek.Monday;
            Assert.IsTrue(DayOfWeek.Monday.Equals(Today), "Siandien ne pirmadienis");

        }

        [Test]

        public static void TestPalauk5sekundes() 
        {
            Thread.Sleep(5000);
        }
    }
}
