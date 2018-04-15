using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreApiDemo.Controllers.v2
{
    /// <summary>
    /// 访问地址：http://localhost:6597/api/v2/Person
    /// </summary>
    [Produces("application/json")]
    //[Route("api/Person")]//加了这个默认的处理就不起作用了
    public class PersonController : Controller
    {
        /// <summary>
        /// http://localhost:6597/api/v1/Person
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<string> Get()
        {
            return "v2";
        }
        /// <summary>
        /// http://localhost:6597/api/v1/Person/GetName
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetName")]
        public async Task<string> GetName()
        {
            return "v 2222";
        }
    }
}
