using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace zipUploader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ZipUploaderController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get() {
            return "Column Mapper Up";
        }

        [HttpPost]
        public async Task Post() {
            var files = Request.Form.Files;
            if (files.Count > 0)
                return ReadCsv(files[0]);
        }
    }
}