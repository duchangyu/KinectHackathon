
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KinectHackathonDataTransferSvc.Controllers
{
    public class TransferController : ApiController
    {
        static List<DataTransfer> datas = new List<DataTransfer>();


        // GET api/transfer
        public IEnumerable<DataTransfer> Get()
        {
            List<DataTransfer> lst = datas.Where(m => m.ReceivedFlag == false) as List<DataTransfer>;
               
            
            foreach (var item in lst)
            {
                datas.Remove(item);
            }


            return lst.AsEnumerable<DataTransfer>();
        }

        // GET api/transfer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/transfer
        public HttpResponseMessage Post(DataTransfer model)
        {
            if (ModelState.IsValid)
            {
                datas.Add(model);


                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, model);

                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // PUT api/transfer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/transfer/5
        public void Delete(int id)
        {
        }
    }
}
