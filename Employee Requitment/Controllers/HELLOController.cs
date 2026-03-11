using Microsoft.AspNetCore.Mvc;

namespace Employee_Requitment.Controllers
{
    public class HELLOController : IHelloService
    { 
        public string SayHello(string name)
        {
            return $"Hello, {name}!";
        }


    }
}
