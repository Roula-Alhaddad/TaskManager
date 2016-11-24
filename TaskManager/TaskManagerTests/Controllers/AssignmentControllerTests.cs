using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Controllers.Tests
{
    [TestClass()]
    public class AssignmentControllerTests
    {
        [TestMethod()]
        public void indexTest()
        {
            var Assignment = new AssignmentController();
            var result = Assignment.index() as ViewResult;
            Assert.Fail();
        }
    }
}