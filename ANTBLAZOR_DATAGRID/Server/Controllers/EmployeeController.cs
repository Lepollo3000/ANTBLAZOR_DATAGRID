using ANTBLAZOR_DATAGRID.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using ANTBLAZOR_DATAGRID.Shared.RequestFeatures;
using ANTBLAZOR_DATAGRID.Server.Utils.Repository;
using Microsoft.EntityFrameworkCore;
using ANTBLAZOR_DATAGRID.Server.Utils.Paging;
using Newtonsoft.Json;
using ANTBLAZOR_DATAGRID.Server.Data;

namespace ANTBLAZOR_DATAGRID.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _dbcontext;

        public EmployeeController(ApplicationDbContext context)
        {
            _dbcontext = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ProductParameters productParameters)
        {
            IEnumerable<Product> products = await _dbcontext.Products
                .Search(productParameters.SearchTerm!)
                .Sort(productParameters.OrderBy!)
                .ToListAsync();

            var response = PagedList<Product>.ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(response.MetaData));

            return Ok(response);
        }
    }
}
