using Microsoft.AspNetCore.Mvc;
using SuccessDash.Shared.Model;
using SuccessDash.Shared.Model.Repositories;

namespace SuccessDash.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<DataOverview> Get()
        {
            DataOverviewRepository repo = new DataOverviewRepository();
            return repo.Select().ToArray();
        }
    }
}
