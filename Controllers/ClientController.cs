using Microsoft.AspNetCore.Mvc;

namespace _BankWebAPI.Controllers
{
    [ApiController]
    [Route("/api/v1/clients")]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public void GetClients([FromQuery] long fromId = 1, [FromQuery] int count = 20)
        {
            fromId = Math.Max(fromId, 1);
            count = Math.Clamp(count, 1, 100);

            Console.WriteLine($"fromId = {fromId}");
            Console.WriteLine($"count = {count}");
        }

        [HttpPost]
        public void CreateClient()
        {

        }

        [HttpGet("{clientId:long}")]
        public void GetClientById([FromRoute] long clientId)
        {

        }

        [HttpDelete("{clientId:long}")]
        public void DeleteClientById([FromRoute] long clientId)
        {

        }
    }
}
