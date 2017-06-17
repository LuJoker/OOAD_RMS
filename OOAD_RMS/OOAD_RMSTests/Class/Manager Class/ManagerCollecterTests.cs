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
    public class ManagerCollecterTests
    {
        ManagerCollecter _mc;
        [TestInitialize()]
        public void ManagerCollecterInit()
        {
            _mc = new ManagerCollecter();
        }
        //[TestMethod()]
        //public void ManagerCollecter_UserManage()
        //{
        //    List<User> userList = _mc.UserManage.GetUsers();
        //    Assert.AreEqual("admin", userList.Find(x => x.UserAccount == "admin").UserAccount);
        //    Assert.AreEqual("Jeff", userList.Find(x => x.UserAccount == "Jeff").UserAccount);
        //    Assert.AreEqual("Leo", userList.Find(x => x.UserAccount == "Leo").UserAccount);
        //}

        //public void ManagerCollecter_ProjectManage()
        //{
        //    User user = _mc.UserManage.getUser("admin","admin");
        //    List<Project> projectList = _mc.ProjectManage.GetProjects(user);
            
        //}
    }
}