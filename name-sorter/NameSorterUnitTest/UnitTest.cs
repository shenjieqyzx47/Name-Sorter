using NUnit.Framework;
using NameSorter;
using System.Collections.Generic;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReadNames_WithCorrectFileAddress_ReturnNameList()
        {
            //Arrange
            string fileAddress = "./UnitTestNameList.txt";
            User userA = new User("Janet Parsons");
            User userB = new User("Vaughn Lewis");
            User userC = new User("Adonis Julius Archer");
            List<User> correctNameList = new List<User>(){userA, userB, userC};
            //Act
            List<User> expectedNameList = Functions.ReadNames(fileAddress);
            //Assert
            for (int i = 0; i <= 2; i++) {
                string correctName = correctNameList[i].Full_name;
                string expectedName = expectedNameList[i].Full_name;
                Assert.AreEqual(expectedName, correctName);
            }
        }
        [Test]
        public void ReadNames_WithInvalidFileAddress_ShouldThrowFileNotFoundException()
        {
            //Arrange
            string fileAddress = "./aaa.txt";
            //Act and Assert
            Assert.Throws<System.IO.FileNotFoundException>(() => Functions.ReadNames(fileAddress));
        }

        [Test]
        public void SortNames_WithUnsortedList_SortedList()
        {
            //Arrange
            User userA = new User("Janet Parsons");
            User userB = new User("Vaughn Lewis");
            User userC = new User("Adonis Julius Archer");
            List<User> unsortedNameList = new List<User>() { userA, userB, userC };
            List<User> expectedNameList = new List<User>() { userC, userB, userA };
            //Act
            List<User> sortedNameList = Functions.SortNames(unsortedNameList);
            //Assert
            for (int i = 0; i <= 2; i++)
            {
                string actualName = sortedNameList[i].Full_name;
                string expectedName = expectedNameList[i].Full_name;
                Assert.AreEqual(expectedName, actualName);
            }
        }

        [Test]
        public void SortNames_WithNullList_ReturnNullList()
        {
            //Arrange
            List<User> nullList = new List<User>();
            //Act
            List<User> expectedNameList = Functions.SortNames(nullList);
            //Assert
            Assert.AreEqual(expectedNameList.Count, nullList.Count);
        }
    }
}