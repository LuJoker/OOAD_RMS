using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOAD_RMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_RMS.Tests
{
    [TestClass()]
    public class UserTests
    {
        User _user;
        [TestInitialize()]
        public void UserInit()
        {
            _user = new User();
        }

        [TestMethod()]
        public void UserAccount()
        {
            _user.UserAccount = "admin";
            Assert.AreEqual("admin", _user.UserAccount);
        }

        [TestMethod()]
        public void UserPassword()
        {
            _user.UserPassword = "admin123";
            Assert.AreEqual("admin123", _user.UserPassword);
        }

        [TestMethod()]
        public void UserIdentity()
        {
            _user.UserIdentity = "member";
            Assert.AreEqual("member", _user.UserIdentity);
        }

    }
}