using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogLibrary;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class EmpInfoTesting
    {
        [Test]
        public void EmpInfo_ValidData_ShouldPassValidation()
        {
            // Arrange
            EmpInfo empInfo = new EmpInfo
            {
                EmailId = "mallika@gmail.com",
                Name = "Mallika",
                PassCode = 12345
            };

        }

        
         
       

    }
}
    

