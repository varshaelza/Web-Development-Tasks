using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTAPI_Example2.Controllers
{
    public class FirstController : ApiController
    {
        [Route ("Greetings")]
        public string GetGreetings()
        {
            return "Hello and Welcome to WebAPI";
        }
        public string GetGreetings(string name)
        {
            return "Hello "+name;
        }
        public int add(int num1,int num2)
        {
            return num1 + num2;
        }
        
        public List<string> GetTechnologies()
        {
            return (new List<string>() { "Cpp","C","Java" });
        }
            
    }
}
