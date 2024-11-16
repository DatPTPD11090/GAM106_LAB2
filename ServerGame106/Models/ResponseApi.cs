using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServerGame106.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseApi
    {
        public bool IsSuccess { get; set; } = true;
        public string Notification { get; set; }
        public object Data { get; set; }
    }
}
