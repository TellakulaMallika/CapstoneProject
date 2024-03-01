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
    public class BlogTests
    {
        // Arrange
        [Test]
        public void BlogInfo_ValidProperties_PassesValidation()
        {
            var blogInfo = new BlogInfo
            {
                BlogId = 25,
                Title = "Docker",
                Subject = "MVC Connect to Docker",
                BlogUrl = "https://github.com/TellakulaMallika/Phase4docker.git/Deploy-an-ASP.NET-WebForms-Application-on-Azure.git",
                EmpEmailId = "mallika@gmail.com",

            };
        }

            

        
        
    }
}


    

