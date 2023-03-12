using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace customerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        // localhost:{PORT}/api/customer adresine yapılan get isteklerinde
        // İsimlerden oluşan bir string listesi döndürülsün.
        public IActionResult Get()
        {
            return Ok(new List<string> { "Hilmi Celayir", "Saniye Y�ld�z", "Nevin Y�ld�z", "Fatih Y�lmaz" });
        }
    }
}
