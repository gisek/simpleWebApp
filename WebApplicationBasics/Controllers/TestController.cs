using Microsoft.AspNetCore.Mvc;

namespace WebApplicationBasics.Controllers
{
    public class TestController : ControllerBase
    {
        [HttpGet("api/hello")]
        public string HelloWorld()
        {
            return "Hello world!";
        }

        [HttpGet("api/sum")]
        public int Get(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }
}
