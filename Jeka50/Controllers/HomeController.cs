using System.Threading.Tasks;
using Jeka50.BDModel;
using Microsoft.AspNetCore.Mvc;

namespace Jeka50.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly TestBdModel _bdModel;
        
        public HomeController(TestBdModel bdModel)
        {
            _bdModel = bdModel;
        }
        
        [HttpGet]
        public async Task<JsonResult> Get(int id)
        {
            return new JsonResult(await _bdModel.Transactions.FindAsync(id));
        }

        [HttpPost]
        public void Post(Transactions transUpdaate)
        {
            
        }

        [HttpPut]
        public void Put(Transactions transUpdaate)
        {
            
        }
        
        [HttpDelete]
        public void Delete(int id)
        {
            
        }
    }
}