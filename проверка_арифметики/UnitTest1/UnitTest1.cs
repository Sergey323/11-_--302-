using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using проверка_арифметики;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // исходные данные
            string stroka = "9*9=81";
            bool expected = true;
            Program g = new  Program();
            bool rezult = g.prover_na_orifmet(stroka);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // исходные данные
            string stroka = "9+9=18";
            bool expected = true;
            Program g = new  Program();
            bool rezult = g.prover_na_orifmet(stroka);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // исходные данные
            string stroka = "9-9=0";
            bool expected = true;
            Program g = new  Program();
            bool rezult = g.prover_na_orifmet(stroka);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // исходные данные
            string stroka = "9^9=1";
            bool expected = false;
            Program g = new  Program();
            bool rezult = g.prover_na_orifmet(stroka);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // исходные данные
            string stroka = "ctg(";
            bool expected = false;
            Program g = new  Program();
            bool rezult = g.prover_na_orifmet(stroka);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            // исходные данные
            string stroka = "";
            bool expected = false;
            Program g = new Program();
            bool rezult = g.prover_na_orifmet(stroka);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }

        [TestMethod]
        public void TestMethod7()
        {
            // исходные данные
            string stroka = "ctg(tg(sin(1)/cos(2)))";
            bool expected = true;
            Program g = new Program();
            bool rezult = g.prover_na_orifmet(stroka);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }
    }
}
