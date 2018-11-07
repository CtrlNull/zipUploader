using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using zipUploader.Models;

namespace zipUploader.Services
{
  public class CsvMappingService
  {
    public MapperReturn CsvPost(SqlConnection cn, DataBaseTableDetails dboDetails)
    {
      List<TableDetails> tableDetails = new List<TableDetails>();
      List<string> fieldMap = new List<string>();
      MapperReturn csv = new MapperReturn();

      using (SqlCommand cmd = new SqlCommand("SELECT column_id, name FROM sys.columns WHERE object_id = OBJECT_ID('" + dboDetails.TableNameDbo + "')", cn))
      using (SqlDataReader reader = cmd.ExecuteReader())
      {
        while (reader.Read())
        {
          tableDetails.Add(new TableDetails()
          {
            FieldIndex = Convert.ToInt32(reader["column_id"]),
            FieldName = Convert.ToString(reader["name"])
          });
        }
        foreach (TableDetails table in tableDetails)
        {
          fieldMap.Add(dboDetails.TableNameMap + ".Add(new CsvFieldMap { FieldIndex = " + (table.FieldIndex - 1) + ", FieldName = '" + table.FieldName + "'});");
        }

        csv = new MapperReturn()
        {
          ListCreator = "List<CsvFieldMap> " + dboDetails.TableNameMap + " = new List<CsvFieldMap>();",
          FieldMap = fieldMap,
          ListAdd = "list.Add(new CsvDataSource('" + dboDetails.TableNameMap + "', " + dboDetails.TableNameMap + "));"
        };
      }
      return csv;
    }
  }
}