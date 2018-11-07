using System.Collections.Generic;

namespace zipUploader.Models
{
    public class MapperReturn
    {
        public string ListCreator { get; set; }
        public List<string> FieldMap { get; set; }
        public string ListAdd { get; set; }
    }

    public class TableDetails
    {
        public int FieldIndex { get; set; }
        public string FieldName { get; set; }

        public string Type { get; set; }
    }
}