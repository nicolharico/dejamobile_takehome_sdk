﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dejamobile_takehome_sdk;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnitTestSdk
{
    [TestClass]
    public class UsersUnitTests
    {
        string testUser = "nicolas";
        string testUserPassword = "password";

        [TestMethod]
        public void CreateUser()
        {
            //arrange
            Sdk sdk = new Sdk();


            //act
            Task<TaskResult> temp = sdk.CreateUser(testUser, testUserPassword);
            TaskResult result = temp.Result;

            //assert
            Assert.IsTrue(result.result);
        }

        [TestMethod]
        public void LogTestUser()
        {
            //arrange
            Sdk sdk = new Sdk();

            //act
            Task<TaskResult> temp = sdk.ConnectUser(testUser, testUserPassword);
            TaskResult result = temp.Result;

            //assert
            Assert.IsTrue(result.result);

            //ensure user is properly connected
            Assert.IsTrue(sdk.getStatus());

        }
    }
}
