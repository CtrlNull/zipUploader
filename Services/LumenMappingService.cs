using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using zipUploader.Models;

namespace zipUploader.Services
{
  public class LumenMappingService
  {
    public MapperReturn LumensPost(SqlConnection cn, DataBaseTableDetails dboDetails)
    {
      List<TableDetails> tableDetails = new List<TableDetails>();
      List<string> fieldMap = new List<string>();
      MapperReturn csv = new MapperReturn();

      using (SqlCommand cmd = new SqlCommand("SELECT DATA_TYPE, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + dboDetails.TableNameDbo + "'", cn))
      using (SqlDataReader reader = cmd.ExecuteReader())
      {
        while (reader.Read())
        {
          tableDetails.Add(new TableDetails()
          {
            Type = ReturnType(Convert.ToString(reader["DATA_TYPE"])),
            FieldName = Convert.ToString(reader["COLUMN_NAME"])
          });

        }
        foreach (TableDetails table in tableDetails)
        {
          fieldMap.Add(dboDetails.TableNameCol + ".Add(new Column { Name = '" + table.FieldName + "', Type = typeof(" + table.Type + ") });");
        }
        csv = new MapperReturn()
        {
          ListCreator = "List<Column> " + dboDetails.TableNameCol + " = new List<Column>();",
          FieldMap = fieldMap,
          ListAdd = "list.Add(new LumenColumns('" + dboDetails.TableName + "', " + dboDetails.TableNameCol + "));"
        };
      }
      return csv;
    }

    public string ReturnType(string type)
    {
      switch (type)
      {
        case "int":
          return "int";
        case "char":
          return "string";
        case "varchar":
          return "string";
        case "nvarchar":
          return "string";
        case "bit":
          return "bool";
        case "date":
          return "DateTime";
        case "numeric":
          return "decimal";
        case "float":
          return "double";
      }
      return null;
    }
  }
}