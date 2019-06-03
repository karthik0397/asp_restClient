using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class DataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DataResponseModel
    {
        public string Response_Status { get; set; }
        public string Response_Message { get; set; }
        public List<DataModel> DataOutput { get; set; }
    }
}