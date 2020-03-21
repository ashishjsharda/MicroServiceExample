using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

namespace MicroServiceExample
{
    class Controller :ApiController
    {
        [Route("hello")]
        public String hello()
        {
            return "Hello";
        }
    }
}
