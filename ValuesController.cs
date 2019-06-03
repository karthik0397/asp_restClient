using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public DataResponseModel ReadValues()
        {
            DataResponseModel objDataResponseModel = new DataResponseModel();
            objDataResponseModel.Response_Status = "Failed";
            objDataResponseModel.Response_Message = "Failed to Start the Operation";
            objDataResponseModel.DataOutput = new List<DataModel>();

            DataModel obj = new DataModel();
            obj.Id = 1;
            obj.Name = "ABCD";
            objDataResponseModel.DataOutput.Add(obj);

            DataModel obj1 = new DataModel();
            obj1.Id = 2;
            obj1.Name = "EFG";
            objDataResponseModel.DataOutput.Add(obj1);

            objDataResponseModel.Response_Status = "Success";
            objDataResponseModel.Response_Message = "Successfully Read the Details";

            return objDataResponseModel;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
