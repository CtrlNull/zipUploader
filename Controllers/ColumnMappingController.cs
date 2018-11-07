using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using zipUploader.Models;

namespace zipUploader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColumnMappingController : ControllerBase
    {
        [HttpPost]
        public MapperReturn Post(string path, string tableName) {
            DataBaseTableDetails tableDetails = new DataBaseTableDetails() {
                TableName = tableName;
                TableNameDbo = "Load_" + tableName;
                TableNameCol = tableName + "Col";
                TableNameMap = tableName + "Map";
            }

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder() {
                // add your connection strings here 
            };
            
            using (SqlConnection cn = new SqlConnection(scsb.ConnectionString)){
                cn.Open()
                switch (path) {
                    case "CSV":
                    return CsvPost(cn, tableDetails);
                    break;
                    case "LUMEN":
                    return null;
                    break;
                }
            }
        }
    }
}