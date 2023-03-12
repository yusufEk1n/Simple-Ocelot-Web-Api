using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace productAPI.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class ProductController : ControllerBase
   {
      // localhost:{PORT}/api/product adresine yapılan get isteklerinde
      // malzemelerden oluşan bir string listesi döndürülsün.
      public IActionResult Get()
      {
         return Ok(new List<string> { "Kalem", "Kitap", "Silgi", "Defter" });
      }

      // localhost:{PORT}/api/product adresine yapılan id ile get isteklerinde
      // ilgili malzeme döndürülsün.
      [HttpGet("{id}")]
      public IActionResult Get(int id)
      {
         return Ok(new List<string> { "Kalem", "Kitap", "Silgi", "Defter" }[id]);
      }
      
      [HttpDelete("[action]")]
      public IActionResult Delete()
      {
         return Ok("Silme işlemi başarılı.");
      }
   }
}
