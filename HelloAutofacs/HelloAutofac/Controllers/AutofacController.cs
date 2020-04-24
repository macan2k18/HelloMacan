using Microsoft.AspNetCore.Mvc;

namespace HelloAutofac.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutofacController : ControllerBase
    {
        private readonly IDataProvider dataProvider;

        public AutofacController(IDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return dataProvider.Get();
        }
    }
}
