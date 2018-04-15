using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreApiDemo.Controllers.v1
{
    /// <summary>
    /// 访问地址：http://localhost:6597/api/v1/Person
    /// </summary>
    [Produces("application/json")]
    // [Route("api/v1/Person")]  //加了这个自定义的NameSpaceVersionRoutingConvention不会起作用，
    //NameSpaceVersionRoutingConvention 中会自动把Rout加上值（ api/v1/Person）
    //NameSpaceVersionRoutingConvention  等同[Route("api/v1/Person")] 但是NameSpaceV...会缓存，只加载一次，效率可能更高
    public class PersonController : Controller
    {
        /// <summary>
        /// http://localhost:6597/api/v1/Person
        /// </summary>
        /// <returns></returns>
        public string Get()
        {
            return "v1";
        }
        /// <summary>
        /// http://localhost:6597/api/v2/Person/GetName
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetName")]
        public async Task<string> GetName()
        {
            return "v 1111";
        }
    }
}