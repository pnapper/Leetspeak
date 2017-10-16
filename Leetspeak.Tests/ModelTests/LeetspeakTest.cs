using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Leetspeak.Models;
using System;

namespace Leetspeak.Tests
  {
    [TestClass]
    public class LeetspeakTest
    {
      [TestMethod]
      public void GetWord_ReturnsResult1_True()
      {
        //Arrange
        LeetspeakGenerator newWord = new LeetspeakGenerator();

        //Act
        var result = newWord.Translate("ear");
        var expected = new List<string> {"3ar"};

        //Assert
        CollectionAssert.AreEqual(expected, result);
      }

      [TestMethod]
      public void GetWord_ReturnsResult2_True()
      {
        //Arrange
        LeetspeakGenerator newWord = new LeetspeakGenerator();

        //Act
        var result = newWord.Translate("bore");
        var expected = new List<string> {"b0r3"};

        //Assert
        CollectionAssert.AreEqual(expected, result);
      }

      [TestMethod]
      public void GetWord_ReturnsResult3_True()
      {
        //Arrange
        LeetspeakGenerator newWord = new LeetspeakGenerator();

        //Act
        var result = newWord.Translate("bottle");
        var expected = new List<string> {"b077l3"};

        //Assert
        CollectionAssert.AreEqual(expected, result);
      }

      [TestMethod]
      public void GetWord_ReturnsResult4_True()
      {
        //Arrange
        LeetspeakGenerator newWord = new LeetspeakGenerator();

        //Act
        var result = newWord.Translate("Ink");
        var expected = new List<string> {"1nk"};

        //Assert
        CollectionAssert.AreEqual(expected, result);
      }

      [TestMethod]
      public void GetWord_ReturnsResult5_True()
      {
        //Arrange
        LeetspeakGenerator newWord = new LeetspeakGenerator();

        //Act
        var result = newWord.Translate("bus");
        var expected = new List<string> {"buz"};

        //Assert
        CollectionAssert.AreEqual(expected, result);
      }

      [TestMethod]
      public void GetWord_ReturnsResult6_True()
      {
        //Arrange
        LeetspeakGenerator newWord = new LeetspeakGenerator();

        //Act
        var result = newWord.Translate("sticks");
        var expected = new List<string> {"s7ickz"};
        foreach (string item in result)
       {
        Console.WriteLine("Output: " + item);
       }

        //Assert
        CollectionAssert.AreEqual(expected, result);
      }
    }
  }
