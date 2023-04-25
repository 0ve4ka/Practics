using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PracticNumberSix.Pages;
using PracticNumberSix;

namespace TestForPracticMethod
{
    [TestClass]
    public class TestForMethod
    {
        //Тесотвые методы для первого метода
        [TestMethod]
        public void TestMethodExOne_Max_IsX()
        {
            int X = 5;
            int Result = ExOnePage.Max(X,3);
            Assert.AreEqual(X, Result);

        }

        [TestMethod]

        public void TestMethodExOne_Max_IsY()
        {
            int Y= 5;
            int Result = ExOnePage.Max(3, Y);
            Assert.AreEqual(Y, Result);
        }

        //Тесотвый метод для второго метода

        [TestMethod]
        public void TestMethodExTwo_F()
        {
            int Num = 12354;
            int Result = ExTwoPage.F(12345);
            Assert.AreEqual(Result,Num);
        }

        //Тесотвый метод для третьего метода

        //Один корень
        [TestMethod]
        public void TestMethodEXThree_RootCount_IsOne()
        {
            int Num = 1;
            int Result = ExThreePage.RootCount(1,2,1);
            Assert.AreEqual(Num,Result);
        }

        //Нет корней
        [TestMethod]

        public void TestMethodEXThree_RootCount_IsZero()
        {
            int Num = 0;
            int Result = ExThreePage.RootCount(2, 3, 4);
            Assert.AreEqual(Num, Result);
        }

        //Два корня
        [TestMethod]

        public void TestMethodEXThree_RootCount_IsTwo()
        {
            int Num = 2;
            int Result = ExThreePage.RootCount(3, 6, 1);
            Assert.AreEqual(Num, Result);
        }

        //Тестовый метод для четвёртого метода
        //Ответ ноль
        [TestMethod]
        public void TestMethodEXFour_IsZero()
        {
            int Num = 0;
            float Result = ExFourPage.Function(2,3);
            Assert.AreEqual(Num, Result);
        }
        //Ответ 1
        [TestMethod]
        public void TestMethodEXFour_IsOne()
        {
            int Num = 1;
            float Result = ExFourPage.Function(3, 3);
            Assert.AreEqual(Num, Result);
        }
        //Ответ деление
        [TestMethod]
        public void TestMethodEXFour()
        {
            float Num = 0.5f;
            float Result = ExFourPage.Function(3, 1);
            Assert.AreEqual(Num, Result);

        }
        //Тестовый метод для первого дополнительного метода
        [TestMethod]

        public void TestMethodEXFive()
        {
            float num = 0.4330127f;
            bool b = false;
            float Result = ExFivePage.Triangle(1,1,1);
            double eps = 0.000001;
            if (Math.Abs(num - Result) < eps)
                b = true;
            Assert.IsTrue(b);
        }

        //Тестовый метод для второго дополнительного метода
        [TestMethod]
        public void TestMethodExSix()
        {
            string Num = "0, 1, 1, 2, 3, ";
            string Result = ExSixPage.Fib(5);
            Assert.AreEqual(Num, Result);
        }

    }
}
