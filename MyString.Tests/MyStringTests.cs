using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStringLibrary;

namespace MyStringTests
{
    [TestClass]
    public class MyStringTests
    {
        [TestMethod]
        public void Create_MyString_HelloWorld_From_CharArray()
        {
            string hw = "Hello, World!";

            MyString myString = new MyString("Hello, World!".ToCharArray());

            Assert.AreEqual(myString.ToString(), hw);
        }

        [TestMethod]
        public void Create_MyString_HelloWorld_From_String_And_ToString()
        {
            string hw = "Hello, World!";

            MyString myString = new MyString("Hello, World!");

            Assert.AreEqual(myString.ToString(), hw);
        }

        [TestMethod]
        public void Equal_Two_MyString_ByValue()
        {
            string hw = "Hello, World!";

            MyString str1 = new MyString(hw.ToCharArray());
            MyString str2 = new MyString(hw);

            Assert.AreEqual(str1, str2);
        }

        [TestMethod]
        public void NotEqual_Two_MyString_ByValue()
        {
            string hw = "Hello, World!";

            MyString str1 = new MyString(hw.ToCharArray());
            MyString str2 = new MyString("Hello, aaaad!");

            Assert.AreNotEqual(str1, str2);
        }


        [TestMethod]
        public void Equal_Two_MyString_ByReference()
        {
            string hw = "Hello, World!";

            MyString str1 = new MyString(hw);
            MyString str2 = str1;

            Assert.IsTrue(str1 == str2);
        }

        [TestMethod]
        public void Сoncatenation_Two_MyString()
        {
            MyString hw = new MyString("Hello, World!");

            MyString str1 = new MyString("Hello, ");
            MyString str2 = new MyString("World!");
            MyString str3 = str1 + str2;

            Assert.AreEqual(str3, hw);
        }

        [TestMethod]
        public void RemovesSubstringFromString ()
        {
            MyString hw = new MyString("Hello, World World Hello!");

            MyString remove = new MyString("World");
            MyString expectedValue = new MyString("Hello,   Hello!");

            MyString value = hw - remove;

            Assert.AreEqual(expectedValue, value);
        }
    }
}
