using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using UnitTestDemo;
using UnitTestDemo.Controllers;

namespace UnitTestDemo.Tests.Controllers
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public void ViewEmployee()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            ViewResult result = controller.ViewEmployee() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void AddEmployee()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            var res = controller.AddEmployee();
            var result = controller.empList ;

            // Assert
            Assert.IsTrue(result[result.Count-1].Length>=3);
        }
        [TestMethod]
        public void Addition()
        {
            // Arrange
            EmployeeController controller = new EmployeeController();

            // Act
            var result = controller.Addition(20, 21);

            // Assert
            Assert.IsTrue(result>50);
        }
    }
}
